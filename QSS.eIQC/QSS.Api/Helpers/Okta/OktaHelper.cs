namespace QSS.eIQC.Api.Helpers.Okta
{
	/// <summary>
	/// Okta helper to map configuration from app settings
	/// </summary>
	public class OktaHelper
	{
		/// <summary>
		/// app setting for okta
		/// </summary>
		public const string OktaConfiguartion = "Okta";

		/// <summary>
		/// origin autority
		/// </summary>
		/// <code>https://{replace-with-okta-domain}.okta.com/oauth2/default</code>
		public string Authority { get; set; }
		/// <summary>
		/// allowed audience
		/// </summary>
		/// <code>api://default</code>
		public string Audience { get; set; }
		public string RequireHttpsMetadata { get; set; }
	}
}
