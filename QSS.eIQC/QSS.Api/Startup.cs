using AutoMapper;
using FluentValidation.AspNetCore;
using HealthChecks.UI.Client;
using MediatR;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using QSS.eIQC.Api.Extensions.Authentication;
using QSS.eIQC.Api.Extensions.Cors;
using QSS.eIQC.Api.Extensions.DependencyInjection;
using QSS.eIQC.Api.Extensions.Environment;
using QSS.eIQC.Api.Extensions.HealthCheck;
using QSS.eIQC.Api.Extensions.Swagger;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Domain.Configuraion;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.Helpers.Filters;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core;
using QSS.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using QSS.eIQC.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using QSS.eIQC.Handlers;
using QSS.eIQC.Handlers.Common;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Implementation;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.Api.Helpers;
using System.Net;
using System.Net.Security;

namespace QSS
{
    /// <summary>
    /// App configuration
    /// </summary>
    public class Startup
    {
        private const string ApiTitle = "QSS.eIQC.Api";
        private const string ApiVersion = "v1";
        private const string Database = "eIQCInMemoryDatabase";
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _currentEnvironment;
        private IOptionsSnapshot<ConnectionStrings> _connectionStrings;
        private IOptionsSnapshot<QSSGatewayAPIOptions> _qssGatewayAPIOptions;

        public Startup(IConfiguration configuration,
            IWebHostEnvironment env) // https://github.com/dotnet/aspnetcore/issues/7749)
        {
            this._configuration = configuration;
            this._currentEnvironment = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public virtual void ConfigureServices(IServiceCollection services)
        {
           
            ConfigureConfigSettings(services);

            // enable policy cors service
	        services.ConfigureCors(_configuration);

            if (_currentEnvironment.IsTest())
            {
                services.UseInMemoryPostgreSqlServer(Database);
            }
            else
            {
                services.UsePostgreSqlServer(_connectionStrings.Value.ApplicationConfigurationConnectionString);
            }
            services.UseSingleTransactionPerRequest();

            services.AddMemoryCache();
            
            services.AddMvc(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
                options.RespectBrowserAcceptHeader = true;
                options.EnableEndpointRouting = false;

                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>()
                            .Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(
                        new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }

                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>()
                    .Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(
                        new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }


                #region enable global authorize feature for all endpoints

                // Enable global authorize feature for all endpoints -Just comment to avoid ise authorization filter in all controllers

               //var policy = new AuthorizationPolicyBuilder()
               //    .RequireAuthenticatedUser()
               //    .Build();
               // options.Filters.Add(new AuthorizeFilter(policy));

                #endregion

            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            .AddJsonOptions(options =>
            {
                //options.SerializerSettings.ContractResolver =
                //    new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
                //options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
            .AddNewtonsoftJson(options => { 
            options.SerializerSettings.ContractResolver  = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
            
            services.AddScoped<IAuthorizationHandler, PermissionHandler>();

            services.AddOData(); // enable OData middleware.

            services.AddScoped<EnableQueryFromODataToAWS>();

            // Workaround: https://github.com/OData/WebApi/issues/1177
            services.AddMvcCore(options =>
            {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
            })

            .AddAuthorization();

            services.AddAutoMapper(Assembly.GetAssembly(typeof(JabilUserModel)), Assembly.GetAssembly(typeof(eIQC.SAPHana.Services.MappingProfile)));

            services.AddMediatR(GetMediatrAssembliesToScan());

            services.AddValidatorsFromAssembly(typeof(BaseCommand).Assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.ConfigureSwaggerExtension(_configuration);

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>
            {
                if (_currentEnvironment.IsDevelopement())
                {
                    return true;
                }
                return errors == SslPolicyErrors.None;
            };

            ConfigureExternalService(services);

            services.Configure<SAPHanaConfiguration>(_configuration.GetSection(nameof(SAPHanaConfiguration)));

            services.AddSingleton<ISAPeHanaClient, SAPHanaClient>(x => new SAPHanaClient(_configuration.GetSection("SAPHanaConfiguration").Get<SAPHanaConfiguration>()));

            #region Register services

            services.DependencyInyectionConfiguration(_configuration);

            services.AwsStorageDependency(_configuration);

            #endregion

            #region OKTA

            services.ConfigureAuth(_configuration);
            //services.ConfigureOkta(_configuration);

            #endregion

            ConfigureHttpContextAccessor(services);

            SetOutputFormatters(services);

            //adding health check services to container
            services.AddHealthChecks()
	            .AddCheck<CustomHealthCheckExtension>("custom");
        }

        private void ConfigureHttpContextAccessor(IServiceCollection services)
        {
	        services.AddHttpContextAccessor();
        }

        #region Configure Third party service
        private void ConfigureExternalService(IServiceCollection services)
        {
            services.AddHttpClient("QssGatewayAPIService", client =>
            {
                client.BaseAddress = new Uri(_qssGatewayAPIOptions.Value.BaseUrl);
            });
        }
        #endregion Configure Third party service


        #region register IOptions

        /// <summary>
        /// Configure all options mapped from app settings
        /// </summary>
        /// <param name="services">app services</param>
        private void ConfigureConfigSettings(IServiceCollection services)
        {
	        services
		        .AddOptions()
		        .Configure<ConnectionStrings>(_configuration.GetSection(nameof(ConnectionStrings)));

	        services
		        .AddOptions()
		        .Configure<QSSGatewayAPIOptions>(_configuration.GetSection(nameof(QSSGatewayAPIOptions)));

	        //services.AddOptions().Configure<TM1Options>(_configuration.GetSection(TM1Options.TM1OptionsSection));

	        services
		        .AddOptions()
		        .Configure<SessionAwsCredentialsOptions>(_configuration.GetSection(nameof(SessionAwsCredentialsOptions)));

	        services
		        .AddOptions()
		        .Configure<FileStorageOptions>(_configuration.GetSection(nameof(FileStorageOptions)));

	        var serviceProvider = services.BuildServiceProvider();

	        _qssGatewayAPIOptions = serviceProvider.GetService<IOptionsSnapshot<QSSGatewayAPIOptions>>();
	        _connectionStrings = serviceProvider.GetService<IOptionsSnapshot<ConnectionStrings>>();
        }

        #endregion

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline. 
        /// </summary>
        /// <param name="app">Application builder DI</param>
        /// <param name="env">Environment DI</param>
        public virtual void Configure
        (
	        IApplicationBuilder app
        )
        {
            if (!_currentEnvironment.IsTest())
            {
                ////To create database & tables on first run.
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<QSSContext>();
                    context.Database.Migrate();
                }
            }
            app.UseCors(CorsExtension.QSSAllowSpecificOrigins);
	        if (_currentEnvironment.IsLocal())
            {
                app.UseDeveloperExceptionPage();
                app.EnableSwaggerPipeline(_configuration);
            }
	        else if (_currentEnvironment.IsDevelopment())
	        {
		        app.UseDeveloperExceptionPage();
		        app.EnableSwaggerPipeline(_configuration);
            }
            else if(_currentEnvironment.IsStaging())
            {
	            app.EnableSwaggerPipeline(_configuration);
            }
            else
            {
	            app.EnableSwaggerPipeline(_configuration);
            }

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            // Please add "UseODataBatching()" before "UseRouting()" to support OData $batch.
            app.UseODataBatching();

			//adding health check point used by the UI
			app.UseHealthChecks("/healthcheck", new HealthCheckOptions()
			{
				Predicate = _ => true,
				ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
			//adding health check UI
			//app.UseHealthChecksUI();

            // https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-3.1&tabs=visual-studio
            app.UseHttpsRedirection();

            app.UseMvc(routebuilder =>
            {
	            routebuilder.EnableDependencyInjection();
	            routebuilder.MaxTop(null);
	            routebuilder.MapODataServiceRoute("ODataRoutes", "odata", 
	                QSS.eIQC.Api.Extensions.OData.ODataExtension.GetODataModels(app.ApplicationServices));
	            // Workaround: https://github.com/OData/WebApi/issues/1175
                
                routebuilder.EnableContinueOnErrorHeader();
                routebuilder.MapRoute(
                    name: "DefaultApi",
                    template: "api/{controller}/{id}");
            });
        }

        #region MediatR Assemblies to scan

        private Type[] GetMediatrAssembliesToScan()
        {
            var assemblies = Assembly.Load("QSS.eIQC.Handlers")
                .GetTypes()
                .ToArray();

            return assemblies;
        }

        #endregion

        /// <summary>
        /// Set formatter to support JSON/ODATA formats
        /// </summary>
        /// <param name="services"></param>
        private static void SetOutputFormatters(IServiceCollection services)
        {
	        services.AddMvcCore(options =>
	        {
		        IEnumerable<ODataOutputFormatter> outputFormatters =
			        options.OutputFormatters.OfType<ODataOutputFormatter>()
				        .Where(formatter => formatter.SupportedMediaTypes.Count == 0);

		        IEnumerable<ODataInputFormatter> inputFormatters =
			        options.InputFormatters.OfType<ODataInputFormatter>()
				        .Where(formatter => formatter.SupportedMediaTypes.Count == 0);

		        foreach (var outputFormatter in outputFormatters)
		        {
			        outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/odata"));
			        outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
		        }

		        foreach (var inputFormatter in inputFormatters)
		        {
			        inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/odata"));
			        inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
		        }
	        });
        }
    }

    
}
