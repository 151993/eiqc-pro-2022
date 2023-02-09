/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand
{
    /// <summary>
    /// Representation model for PartResultOrientedParameter entity
    /// </summary>
    public class SupplierVisualInspectionModel : BaseStausModel<int>
    {
        public int SupplierVisualInspectionId { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }
        public int ParameterManagementId { get; set; }
        public int PartCountParameterId { get; set; }

        public int SamplingSize { get; set; }

        public virtual PartCountParameterModel PartCountParameter { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public List<int> AddedDefectTypeIds { get; set; }
        
        public virtual IEnumerable<DefectTypeModel> DefectTypes { get; set; }

        public virtual ICollection<SupplierVisualInspectionDefectTypeModel> SupplierVisualInspectionDefectTypes { get; set; }

        public int? TotalDefectQty { get; set; }

        public int ResultPassFailId { get; set; }

        public string InspectionDetails { get; set; }

        public int InspectionToolsId { get; set; }

        public int? InspectionToolsTypeId { get; set; }
        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string DetailsDefine { get; set; }
        public virtual ParameterManagementModel ParameterManagement { get; set; }
        public virtual InspectionToolsModel InspectionTools { get; set; }
        public virtual InspectionToolsTypeModel InspectionToolsType { get; set; }

    }
}
