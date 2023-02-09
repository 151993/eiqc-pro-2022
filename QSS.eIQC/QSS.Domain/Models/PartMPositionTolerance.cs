/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartMPositionTolerance entity model to map database PartMPositionTolerance table 
    /// </summary>
    public class PartMPositionTolerance : PersistentObjectWithUpdate<int>
    {
        public PartMPositionTolerance()
        {
        }
        public double? SpecLimitAtMMC { get; set; }

        public double? SpecLimitAtLMC { get; set; }

        public double? Spec { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }
                   
        public int PartDimensionId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int DataTypeId { get; set; }
         
        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }
         
        public virtual PartDimension PartDimension { get; set; }
         
        public virtual ParameterManagement ParameterManagement { get; set; }
         
        public virtual UOM UOM { get; set; }
         
        public virtual InstrumentType InstrumentType { get; set; }

        public virtual DataTypeModel DataType { get; set; }
    }
}
