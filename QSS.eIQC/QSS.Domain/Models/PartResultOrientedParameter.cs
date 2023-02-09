/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartResultOrientedParameter entity model to map database PartResultOrientedParameter table 
    /// </summary>
    public class PartResultOrientedParameter : PersistentObjectWithUpdate<int>
    {
        public PartResultOrientedParameter()
        {
        }

        public int SAPPartInspectionPlanId { get; set; }

        public int ParameterManagementId { get; set; }

        public int ResultId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }
    }
}
