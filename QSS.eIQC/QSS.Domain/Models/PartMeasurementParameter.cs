/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartMeasurementParameter entity model to map database PartMeasurementParameter table 
    /// </summary>
    public class PartMeasurementParameter: PersistentObjectWithUpdate<int>
    {
        public PartMeasurementParameter()
        {
        }
       
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

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual UOM UOM { get; set; }

        public virtual InstrumentType InstrumentType { get; set; }

        public virtual DataTypeModel DataType { get; set; }
        public virtual ChartTypeModel ChartType { get; set; }

    }
}
