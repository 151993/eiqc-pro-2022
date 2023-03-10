using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace QSS.eIQC.Api.Helpers.Filters
{
	/// <summary>
	/// Custom attribute to pass OData query params to API Gateway
	/// </summary>
	/// <remarks>
	/// BUG: https://github.com/aws/aws-lambda-dotnet/issues/694
	/// BUG: https://github.com/OData/WebApi/issues/1227
	/// </remarks>
	public class EnableQueryFromODataToAWS : EnableQueryAttribute
	{
		/// <summary>
		/// Action executed on request
		/// </summary>
		/// <param name="actionExecutedContext">Requested context <see cref="ActionExecutedContext"/></param>
		public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
		{
			actionExecutedContext.HttpContext.Response.StatusCode = 200;
			base.OnActionExecuted(actionExecutedContext);
		}
	}
}
