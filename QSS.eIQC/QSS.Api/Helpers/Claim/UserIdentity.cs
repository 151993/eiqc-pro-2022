using System.Collections.Generic;

namespace QSS.Helpers.Claim
{
    public class UserIdentity
    {
        public UserIdentity()
        {
            Roles = new List<string>();
        }

        public int UserId { get; set; }

        public string SamAccountName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<string> Roles { get; set; }
    }
}
