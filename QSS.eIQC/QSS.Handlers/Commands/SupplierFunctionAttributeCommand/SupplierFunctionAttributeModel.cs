/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands
{
    /// <summary>
    /// Representation model for PartResultOrientedParameter entity
    /// </summary>
    public class SupplierFunctionAttributeModel : BaseStausModel<int>
    {
        public int SupplierFunctionAttributeId { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int ParameterManagementId { get; set; }

        public int ResultId { get; set; }

        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public string InspectionDetails { get; set; }

        public int ResultPassFailId { get; set; }

        public int ResultActualId { get; set; }

        public List<int> AddedDefectTypeIds { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

        public virtual IEnumerable<DefectTypeModel> DefectTypes { get; set; }

        public virtual IEnumerable<SupplierFunctionAttributeActualModel> SupplierFunctionAttributeActuals { get; set; }


    }
}
