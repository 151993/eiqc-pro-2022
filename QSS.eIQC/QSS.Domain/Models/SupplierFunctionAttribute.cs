/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartResultOrientedParameter entity model to map database PartResultOrientedParameter table 
    /// </summary>
    public class SupplierFunctionAttribute : PersistentObjectWithUpdate<int>
    {
        public SupplierFunctionAttribute()
        {
            SupplierFunctionAttributeDefectTypes = new HashSet<SupplierFunctionAttributeDefectType>();
            SupplierFunctionAttributeActuals = new HashSet<SupplierFunctionAttributeActual>();

        }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int ParameterManagementId { get; set; }

        public int ResultId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public string InspectionDetails { get; set; }

        public int ResultPassFailId { get; set; }

        public int ResultActualId { get; set; }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual ICollection<SupplierFunctionAttributeDefectType> SupplierFunctionAttributeDefectTypes { get; set; }

        public virtual ICollection<SupplierFunctionAttributeActual> SupplierFunctionAttributeActuals { get; set; }




    }
}
