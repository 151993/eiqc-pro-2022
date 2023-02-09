/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.PartCountParameterCommand
{
    /// <summary>
    /// Representation model for PartCountParameter entity
    /// </summary>
    public class PartCountParameterModel : BaseStausModel<int>
    {
        public int PartCountParameterId { get; set; }

        public int? SAPPartInspectionPlanId { get; set; }

        public int? ParameterManagementId { get; set; }

        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string DetailsDefine { get; set; }

        public int? InspectionToolsTypeId { get; set; }

        public int? DataTypeId { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

        public virtual InspectionToolsTypeModel InspectionToolsType { get; set; }

    }
}
