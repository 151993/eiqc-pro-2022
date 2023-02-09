using Microsoft.AspNetCore.Http;
using Moq;
using System.Security.Claims;

namespace QSS.eIQC.UnitTests.Core
{
    public  static class MoqUserIdentity
    {
        private const string UserIdClaimKey = "userid";
        private const string NameClaimKey = "name";
        private const string UserIdClaimValue = "1";
        private const string NameClaimValue = "system_user@jabil.com";

        public static Mock<IHttpContextAccessor> GetUserIdentity()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                       {
                            new Claim(UserIdClaimKey, UserIdClaimValue),
                            new Claim(NameClaimKey, NameClaimValue),
                       }, "moq"));
            var context = new DefaultHttpContext();
            context.User = user;
            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);

            return mockHttpContextAccessor;
        }
    }
}
