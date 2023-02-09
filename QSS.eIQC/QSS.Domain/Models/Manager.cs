
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Manager : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Manager()
        {
            User = new HashSet<User>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Email { get; set; }

        public virtual ICollection<User> User { get; set; }

    }
}
