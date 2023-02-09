using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using QSS.eIQC.IntegrationTests.Core.Common;

namespace QSS.eIQC.IntegrationTests.Core.TestAuth
{
    public class TestAuthHandler : AuthenticationHandler<TestAuthenticationOptions>
    {
        public TestAuthHandler(IOptionsMonitor<TestAuthenticationOptions> options,
            ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var authenticationTicket = new AuthenticationTicket(
                new ClaimsPrincipal(Options.Identity),
                new AuthenticationProperties(),
                Constants.AuthenticationScheme.TestScheme);

            return Task.FromResult(AuthenticateResult.Success(authenticationTicket));
        }

    }
  
}
