
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Country : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Country()
        {
            Location = new HashSet<Location>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public int RegionId { get; set; }

        [AuditLog(DisplayName = "Region", ValueField = "Name", MappingField = "RegionId")]
        public virtual Region Region { get; set; }

        public virtual ICollection<Location> Location { get; set; }

    }
}
