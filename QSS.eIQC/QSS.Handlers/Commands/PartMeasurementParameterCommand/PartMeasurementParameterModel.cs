/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;

namespace QSS.eIQC.Handlers.Commands.PartMeasurementParameterCommand
{
    /// <summary>
    /// Representation model for PartMeasurementParameter entity
    /// </summary>
    public class PartMeasurementParameterModel : BaseStausModel<int>
    {
        public int PartMeasurementParameterId { get; set; }

        public double? NormalValue { get; set; }

        public double? UpperTolerance { get; set; }

        public double? LowerTolerance { get; set; }

        public int? Accuracy { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int DataTypeId { get; set; }

        public int? ChartTypeId { get; set; }

        public int CalculationPoint { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

        public virtual UOMModel UOM { get; set; }

        public virtual InstrumentTypeModel InstrumentType { get; set; }

        public virtual DataTypeModel DataType { get; set; }

        public virtual ChartTypeModel ChartType { get; set; }

    }
}
