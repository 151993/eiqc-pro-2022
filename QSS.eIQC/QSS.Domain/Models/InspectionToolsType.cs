/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// InspectionToolsType entity model to map database InspectionToolsType table 
    /// </summary>
    public class InspectionToolsType : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public InspectionToolsType()
        {
            InspectionTools = new HashSet<InspectionTools>();
            InspectionToolsTypePcCodes = new HashSet<InspectionToolsTypePcCode>();
            PartCountParameters = new HashSet<PartCountParameter>();
            SupplierVisualInspections = new HashSet<SupplierVisualInspection>();
        }

        [AuditLog]
        [Unique]
        public string Type { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<InspectionTools> InspectionTools { get; set; }

        public virtual ICollection<InspectionToolsTypePcCode> InspectionToolsTypePcCodes { get; set; }

        public virtual ICollection<PartCountParameter> PartCountParameters { get; set; }
        public virtual ICollection<SupplierVisualInspection> SupplierVisualInspections { get; set; }

    }
}
