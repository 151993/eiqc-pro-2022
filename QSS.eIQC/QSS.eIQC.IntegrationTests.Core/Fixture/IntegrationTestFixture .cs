using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;
using System.Net.Http;

namespace QSS.eIQC.IntegrationTests.Core
{
    public class IntegrationTestFixture : IDisposable
    {
        private const string ApplicationFolder = "../../../../QSS.Api";
        private const string BaseAddress = "http://localhost:8001/";
        private const string Environment = "Test";
        protected readonly TestServer _server;
        public HttpClient _client;
      
        public IntegrationTestFixture()
        {
            // To avoid hard coding path to project, see: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing#integration-testing
            var integrationTestsPath = PlatformServices.Default.Application.ApplicationBasePath; // integration_tests/bin/Debug/netcoreapp
            var applicationPath = Path.GetFullPath(Path.Combine(integrationTestsPath, ApplicationFolder));

            _server = new TestServer(WebHost.CreateDefaultBuilder()
                .UseStartup<TestStartup>()
                .UseContentRoot(applicationPath)
                .ConfigureTestServices(services =>
                {
                    services.AddMvc(options =>
                    {
                        options.Filters.Add(new MoqUserFilter());
                    }).AddApplicationPart(typeof(Startup).Assembly);
                })
                .UseEnvironment(Environment));

            _client = _server.CreateClient();
            _client.BaseAddress = new Uri(BaseAddress);

        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }
  
}
