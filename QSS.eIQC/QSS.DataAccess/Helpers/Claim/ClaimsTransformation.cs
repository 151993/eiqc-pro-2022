using System;
using System.Linq;
using System.Security.Claims;

namespace QSS.eIQC.DataAccess.Helpers.Claim
{
    public static class ClaimsTransformation
    {
        public static UserIdentity Transform(ClaimsPrincipal claimsPrincipal)
        {
            var claims = claimsPrincipal.Claims.Select(c => new
            {
                type = c.Type,
                value = c.Value
            });

            var user = new UserIdentity();

            foreach (var claim in claims)
            {
                if (claim.type.ToLower().Contains("userid"))
                {
                    user.UserId = Convert.ToInt32(claim.value);
                }
                else if (claim.type.ToLower().Contains("samaccount"))
                {
                    user.SamAccountName = claim.value;
                }
                else if (claim.type.ToLower().Contains("emailaddress"))
                {
                    user.Email = claim.value;
                }
                else if (claim.type.ToLower().Contains("role"))
                {
                    if (!string.IsNullOrWhiteSpace(claim.value))
                    {
                        user.Roles.Add(Int32.Parse(claim.value));
                    }
                }
                else if (claim.type.ToLower().Contains("name"))
                {
                    user.Name = claim.value;
                }
            }

            return user;
        }
    }
}
