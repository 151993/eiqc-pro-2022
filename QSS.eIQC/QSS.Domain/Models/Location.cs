
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Location : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Location()
        {
            Site = new HashSet<Site>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public int CountryId { get; set; }

        [AuditLog(DisplayName = "Country", ValueField = "Name", MappingField = "CountryId")]
        public virtual Country Country { get; set; }

        public virtual ICollection<Site> Site { get; set; }

    }
}
