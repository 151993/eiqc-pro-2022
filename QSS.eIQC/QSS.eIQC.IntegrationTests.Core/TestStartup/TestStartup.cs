using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using QSS.eIQC.IntegrationTests.Core.TestAuth;
using QSS.eIQC.IntegrationTests.Core.Common;
using System.Security.Claims;
using static QSS.eIQC.IntegrationTests.Core.Common.Constants;

namespace QSS.eIQC.IntegrationTests.Core
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration, IWebHostEnvironment env) : base(configuration, env)
        {
        }
        public override void ConfigureServices(IServiceCollection services)
        {
            // Perform all the configuration in the base class
            base.ConfigureServices(services);
            
            // Register the database seeder
            services.AddTransient<SeedMoqData>();

              services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = Constants.AuthenticationScheme.TestScheme; // has to match scheme in TestAuthenticationExtensions
                options.DefaultChallengeScheme = Constants.AuthenticationScheme.TestScheme;

            }).AddTestAuth(o => { });
           
        }
        
        public override void Configure(IApplicationBuilder app)
        {
            // Perform all the configuration in the base class
            base.Configure(app);
         
            // Now seed the database
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var seeder = serviceScope.ServiceProvider.GetService<SeedMoqData>();
                seeder.Seed().Wait();
            }
        }
    }
}
