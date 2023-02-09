using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Helpers.Claim
{
    public class UserIdentity
    {
        public UserIdentity()
        {
            Roles = new List<int>();
        }

        public int UserId { get; set; }

        public string SamAccountName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<int> Roles { get; set; }
    }
}
