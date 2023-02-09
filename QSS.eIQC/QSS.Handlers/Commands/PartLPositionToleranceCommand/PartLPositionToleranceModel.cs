/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;

namespace QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand
{
    /// <summary>
    /// Representation model for PartLPositionTolerance entity
    /// </summary>
    public class PartLPositionToleranceModel : BaseStausModel<int>
    {
        public int PartLPositionToleranceId { get; set; }

        public double? SpecLimitAtMMC { get; set; }

        public double? SpecLimitAtLMC { get; set; }

        public double? Spec { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }

        public int PartDimensionId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int DataTypeId { get; set; }

        public virtual PartDimensionModel PartDimension { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

        public virtual UOMModel UOM { get; set; }

        public virtual InstrumentTypeModel InstrumentType { get; set; }

    }
}
