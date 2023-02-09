/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Part entity model to map database Part table 
    /// </summary>
    public class Part : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Part()
        {
            GRS = new HashSet<GRS>();
        }

        [AuditLog]
        [Unique]
        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string Site { get; set; }

        public string Commodity { get; set; }

        public string MPNMaterial { get; set; }

        public string Mediacode { get; set; }

        public string MaskedMPN { get; set; }

        public string Manufacturer { get; set; }

        public string Vendor { get; set; }

        public virtual ICollection<GRS> GRS { get; set; }


    }
}
