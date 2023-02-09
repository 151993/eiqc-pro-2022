using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using QSS.eIQC.IntegrationTests.Core.Common;

namespace QSS.eIQC.IntegrationTests.Core.TestAuth
{
    public static class TestAuthenticationExtensions
    {
        private const string DisplayName = "Test Auth";
        public static AuthenticationBuilder AddTestAuth(this AuthenticationBuilder builder, Action<TestAuthenticationOptions> configureOptions)
        {
            return builder.AddScheme<TestAuthenticationOptions, TestAuthHandler>(Constants.AuthenticationScheme.TestScheme, DisplayName, configureOptions);
        }
    }
}
