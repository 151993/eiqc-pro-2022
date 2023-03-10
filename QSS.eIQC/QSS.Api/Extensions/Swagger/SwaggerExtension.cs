using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;

namespace QSS.eIQC.Api.Extensions.Swagger
{
	/// <summary>
	/// Swagger extension
	/// </summary>
	public static class SwaggerService
	{
		#region Swagger Configuration
		/// <summary>
		/// Method to configure the Swagger Services within the Application services interface
		/// </summary>
		/// <param name="services">The Service Collection <see cref="IServiceCollection"/></param>
		/// <param name="config">The Service Collection <see cref="IConfiguration"/></param>
		public static void ConfigureSwaggerExtension(this IServiceCollection services, IConfiguration config)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
				{
					Title = config["SwaggerConfiguration:Title"], 
					Version = config["SwaggerConfiguration:Version"],
					Description = config["SwaggerConfiguration:Description"]
				});

				// Set the comments path for the Swagger JSON and UI.
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

				c.IncludeXmlComments(xmlPath);

				// Manually populating the OData Endpoints in the swagger page
				// c.DocumentFilter<CustomODataDocumentFilter>(xmlPath);
				//c.DocumentFilter<CustomODataDocumentFilter>();
			});
		}
		#endregion

		/// <summary>
		/// Enable Swagger pipeline
		/// </summary>
		/// <param name="app">application configuration <see cref="IApplicationBuilder"/></param>
		/// <param name="config">application settings <see cref="IConfiguration"/></param>
		public static void EnableSwaggerPipeline(this IApplicationBuilder app, IConfiguration config)
		{
			app.UseSwagger();
			app.UseSwaggerUI(option =>
			{
				option.SwaggerEndpoint(
					config["SwaggerConfiguration:SwaggerJSONEndpoints"], 
					$"{config["SwaggerConfiguration:Title"]} {config["SwaggerConfiguration:Version"]}");
				// To serve the Swagger UI at the apps root
				option.RoutePrefix = string.Empty;
			});
		}
	}
}
