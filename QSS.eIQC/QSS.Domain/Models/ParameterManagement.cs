/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ParameterManagement entity model to map database ParameterManagement table 
    /// </summary>
    public class ParameterManagement : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public ParameterManagement()
        {
            ParameterManagementCommodity = new HashSet<ParameterManagementCommodity>();
            PartMPositionTolerances = new HashSet<PartMPositionTolerance>();
            PartLPositionTolerances = new HashSet<PartLPositionTolerance>();
            PartMeasurementParameters = new HashSet<PartMeasurementParameter>();
            PartFunParameters = new HashSet<PartFunParameter>();
            PartMicrosectionParameters = new HashSet<PartMicrosection>();
            PartResultOrientedParameters = new HashSet<PartResultOrientedParameter>();
            PartCountParameters = new HashSet<PartCountParameter>();
            SupplierFunctionAttributes = new HashSet<SupplierFunctionAttribute>();

            SupplierMicrosectionParameters = new HashSet<SupplierMicrosection>();
            SupplierDimensionMeasurements = new HashSet<SupplierDimensionMeasurement>();
            SupplierFunctionVariables = new HashSet<SupplierFunctionVariable>();
            SupplierVisualInspections = new HashSet<SupplierVisualInspection>();
        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

       

        [AuditLog]
        public int ParameterTypeCodeId { get; set; } 

        public virtual ParameterTypeCode ParameterTypeCode { get; set; }

        public virtual ICollection<ParameterManagementCommodity> ParameterManagementCommodity { get; set; }

        public virtual ICollection<PartMPositionTolerance> PartMPositionTolerances { get; set; }

        public virtual ICollection<PartLPositionTolerance> PartLPositionTolerances { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<PartResultOrientedParameter> PartResultOrientedParameters { get; set; }

        public virtual ICollection<PartCountParameter> PartCountParameters { get; set; }

        public virtual ICollection<SupplierFunctionAttribute> SupplierFunctionAttributes { get; set; }
        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }
        public virtual ICollection<SupplierVisualInspection> SupplierVisualInspections { get; set; }
        


    }
}
