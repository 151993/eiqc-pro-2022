using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QSS.Security;
using System;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Api.Extensions.Authentication
{
	/// <summary>
	/// original QSS service to provide authentication
	/// </summary>
	public static class ConfigureAuthentication
	{
		/// <summary>
		/// Configures identity provider
		/// </summary>
		/// <param name="services">net service</param>
		/// <param name="configuration">app configuration</param>
		public static void ConfigureAuth(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddAuthentication("Bearer")
				.AddJwtBearer("Bearer", options =>
				{
					options.Authority = configuration.GetValue<string>("IdentityServer:Authority");
					options.RequireHttpsMetadata = configuration.GetValue<bool>("IdentityServer:RequireHttpsMetadata");

					options.Audience = configuration.GetValue<string>("IdentityServer:Audience");

					options.SaveToken = configuration.GetValue<bool>("IdentityServer:SaveToken");
				});

			services.AddScoped<IAuthorizationHandler, PermissionHandler>();

			services.AddAuthorization(options =>
			{
				foreach (PermissionType permissionType in Enum.GetValues(typeof(PermissionType)))
				{
					options.AddPolicy(permissionType.ToString(), policy => policy.Requirements.Add(new PermissionRequirement(permissionType)));
				}
			});
		}
    }
}
