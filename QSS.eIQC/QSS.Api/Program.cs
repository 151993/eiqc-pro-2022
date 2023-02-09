using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace QSS.eIQC.Api
{
	[ExcludeFromCodeCoverage]
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            Log.Information("Application Started from Program.Main");

            await CreateHostBuilder(args).Build().RunAsync();

            return 0;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    Log.Information($"Current Environment: {hostingContext.HostingEnvironment.EnvironmentName.ToString()}");

                    var envName = hostingContext.HostingEnvironment.EnvironmentName.ToString();
                    config.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{envName}.json", optional: false, reloadOnChange: true);
                   // .AddSystemsManager($"/QSS.eIQC.Api/{envName}", TimeSpan.FromMinutes(5));
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseSerilog();
                });
    }
}
