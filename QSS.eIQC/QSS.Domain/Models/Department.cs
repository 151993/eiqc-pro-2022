using QSS.Models;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Department : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Department()
        {
 			User = new HashSet<User>();
        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<User> User { get; set; }

    }
}