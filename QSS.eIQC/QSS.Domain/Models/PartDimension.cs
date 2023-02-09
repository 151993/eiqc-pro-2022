/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartDimension entity model to map database PartDimension table 
    /// </summary>
    public class PartDimension : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartDimension()
        {
            PartMPositionTolerances = new HashSet<PartMPositionTolerance>();
            PartLPositionTolerances = new HashSet<PartLPositionTolerance>();

        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<PartMPositionTolerance> PartMPositionTolerances { get; set; }

        public virtual ICollection<PartLPositionTolerance> PartLPositionTolerances { get; set; }

    }
}
