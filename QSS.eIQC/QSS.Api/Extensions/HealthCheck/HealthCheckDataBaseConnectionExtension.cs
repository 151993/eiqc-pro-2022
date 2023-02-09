using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Extensions.HealthCheck
{
	public class HealthCheckDataBaseConnectionExtension: IHealthCheck
	{
		/// <summary>
		/// App settings data DI
		/// </summary>
		private readonly IConfiguration _config;

		public HealthCheckDataBaseConnectionExtension(IConfiguration config)
		{
			_config = config;
		}

		/// <summary>
		/// database health check 
		/// </summary>
		/// <param name="context">Health check context <see cref="HealthCheckContext"/></param>
		/// <param name="cancellationToken">cancellation token <see cref="CancellationToken"/></param>
		/// <returns></returns>
		public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
			try
			{
				var connection = new NpgsqlConnection(_config["ConnectionStrings:ApplicationConfigurationConnectionString"]);
				connection.Open();
				data["Result"] = "Success";
				connection.Close();
			}
			catch (Exception exception)
			{
				data["Result"] = exception.Message;
				return Task.FromResult(
					HealthCheckResult.Unhealthy("Unhealthy database connection", exception,data));
			}
			return Task.FromResult(HealthCheckResult.Healthy("Healthy database connection",data));
		}
	}
}
