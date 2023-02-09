

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Region : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Region()
        {
            Country = new HashSet<Country>();

        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<Country> Country { get; set; }

    }
}