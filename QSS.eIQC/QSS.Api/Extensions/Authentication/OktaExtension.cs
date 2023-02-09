using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Okta.AspNetCore;
using QSS.eIQC.Api.Helpers.Okta;
using QSS.eIQC.Domain.Enums;
using QSS.Security;
using System;

namespace QSS.eIQC.Api.Extensions.Authentication
{
	/// <summary>
	/// enables Okta service
	/// </summary>
	public static class OktaExtension
	{
		
		/// <summary>
		/// enables Okta service, this replace original service <see cref="ConfigureAuthentication"/>
		/// </summary>
		/// <param name="services">application service <see cref="IServiceCollection"/></param>
		/// <param name="configuration">application configuration <see cref="IConfiguration"/></param>
		public static void ConfigureOkta(this IServiceCollection services, IConfiguration configuration)
		{
			var okta = configuration.GetSection(OktaHelper.OktaConfiguartion).Get<OktaHelper>();

			services.AddAuthentication(options =>
				{
					options.DefaultAuthenticateScheme = OktaDefaults.ApiAuthenticationScheme;
					options.DefaultChallengeScheme = OktaDefaults.ApiAuthenticationScheme;
					options.DefaultSignInScheme = OktaDefaults.ApiAuthenticationScheme;
				})
				.AddCookie()
				.AddJwtBearer(options =>
				{
					options.Authority = okta.Authority;
					options.Audience = okta.Audience;
					options.RequireHttpsMetadata = Convert.ToBoolean(okta.RequireHttpsMetadata);
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
