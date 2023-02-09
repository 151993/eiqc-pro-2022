using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.Common
{
    public static class Constants
    {
        public static class MediaType
        {
            public const string Json = "application/json";
        }
        public static class AuthenticationScheme
        {
            public const string TestScheme = "Test Scheme";
        }

        public static class TestUserClaims
        {
            public const string UserIdClaimKey = "userid";
            public const string NameClaimKey = "name";
            public const string UserIdClaimValue = "1";
            public const string NameClaimValue = "system_user@jabil.com";
        }
    }
}
