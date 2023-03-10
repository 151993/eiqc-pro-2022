using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QSS.eIQC.Api.Extensions.Cors
{
	/// <summary>
	/// Extension to setup CORS configuration
	/// </summary>
	public static class CorsExtension
	{
		/// <summary>
		/// Policy cors name
		/// </summary>
		public static readonly string QSSAllowSpecificOrigins = "QSSAllowSpecificOrigins";

		/// <summary>
		/// CORS configurations
		/// </summary>
		/// <param name="services">application service <see cref="IServiceCollection"/></param>
		/// <param name="configuration">app settings configuration <see cref="IConfiguration"/></param>
		public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddCors(options =>
			{
				options.AddPolicy(QSSAllowSpecificOrigins,
					builder =>
					{
						builder.WithOrigins(configuration.GetSection("Cors:AllowedOrigin").Get<string[]>())
							.AllowAnyHeader()
							.AllowAnyMethod()
							.AllowCredentials();
					});
			});
		}
	}
}
