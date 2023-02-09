/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierTestReport entity model to map database SupplierTestReport table 
    /// </summary>
    public class SupplierVisualInspection : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierVisualInspection()
        {
            SupplierVisualInspectionDefectTypes = new HashSet<SupplierVisualInspectionDefectType>();
        }

        public int SupplierMeasurementSubmissionId { get; set; }
        public int ParameterManagementId { get; set; }
        public int PartCountParameterId { get; set; }

        public int SamplingSize { get; set; }

        public int ResultPassFailId { get; set; }

        public string InspectionDetails { get; set; }

        public int? InspectionToolsId { get; set; }

        public int? TotalDefectQty { get; set; }
        public int? InspectionToolsTypeId { get; set; }
        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string DetailsDefine { get; set; }
        public virtual InspectionTools InspectionTools { get; set; }

        public virtual PartCountParameter PartCountParameter { get; set; }
        
        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }
        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual ICollection<SupplierVisualInspectionDefectType> SupplierVisualInspectionDefectTypes { get; set; }
        public virtual InspectionToolsType InspectionToolsType { get; set; }

    }
}
