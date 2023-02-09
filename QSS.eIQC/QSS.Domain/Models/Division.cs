

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Division : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Division()
        {
            SiteDivisions = new HashSet<SiteDivision>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<SiteDivision> SiteDivisions { get; set; }

    }
}
