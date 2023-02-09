/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.PartResultOrientedParameterCommand
{
    /// <summary>
    /// Representation model for PartResultOrientedParameter entity
    /// </summary>
    public class PartResultOrientedParameterModel : BaseStausModel<int>
    {
        public int PartResultOrientedParameterId { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }

        public int ResultId { get; set; }

        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

    }
}
