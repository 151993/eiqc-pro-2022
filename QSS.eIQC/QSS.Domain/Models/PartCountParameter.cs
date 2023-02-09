/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartCountParameter entity model to map database PartCountParameter table 
    /// </summary>
    public class PartCountParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartCountParameter()
        {
            this.SupplierVisualInspections = new HashSet<SupplierVisualInspection>();
        }

        public int? SAPPartInspectionPlanId { get; set; }

        public int? ParameterManagementId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public string DetailsDefine { get; set; }

        public int? InspectionToolsTypeId { get; set; }

        public int? DataTypeId { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual InspectionToolsType InspectionToolsType { get; set; }

        public virtual ICollection<SupplierVisualInspection> SupplierVisualInspections { get; set; }

 


    }
}
