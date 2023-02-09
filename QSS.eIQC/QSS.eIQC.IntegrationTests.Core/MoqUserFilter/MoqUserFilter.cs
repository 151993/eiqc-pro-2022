using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static QSS.eIQC.IntegrationTests.Core.Common.Constants;

namespace QSS.eIQC.IntegrationTests.Core
{
    public class MoqUserFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
        {
                            new Claim(TestUserClaims.UserIdClaimKey, TestUserClaims.UserIdClaimValue),
                            new Claim(TestUserClaims.NameClaimKey, TestUserClaims.NameClaimValue),
        }));

            await next();
        }
    }
}
