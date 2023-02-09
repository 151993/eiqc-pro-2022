using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using static QSS.eIQC.IntegrationTests.Core.Common.Constants;

namespace QSS.eIQC.IntegrationTests.Core.TestAuth
{
    public class TestAuthenticationOptions : AuthenticationSchemeOptions
    {
       
        private const string AuthenticationType = "Test";

        public virtual ClaimsIdentity Identity { get; } = new ClaimsIdentity(new Claim[]
        {
                            new Claim(TestUserClaims.UserIdClaimKey, TestUserClaims.UserIdClaimValue),
                            new Claim(TestUserClaims.NameClaimKey, TestUserClaims.NameClaimValue),
        }, AuthenticationType);
    }
}
