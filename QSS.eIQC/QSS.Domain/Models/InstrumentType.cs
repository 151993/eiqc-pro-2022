/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// InstrumentType entity model to map database InstrumentType table 
    /// </summary>
    public class InstrumentType : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        public InstrumentType()
        {
            Instrument = new HashSet<Instrument>();
            PartMPositionTolerances = new HashSet<PartMPositionTolerance>();
            PartLPositionTolerances = new HashSet<PartLPositionTolerance>();
            PartMeasurementParameters = new HashSet<PartMeasurementParameter>();
            PartFunParameters = new HashSet<PartFunParameter>();
            PartMicrosectionParameters = new HashSet<PartMicrosection>();

            SupplierMicrosectionParameters = new HashSet<SupplierMicrosection>();
            SupplierDimensionMeasurements = new HashSet<SupplierDimensionMeasurement>();
            SupplierFunctionVariables = new HashSet<SupplierFunctionVariable>();
        }
        [AuditLog]
        [Unique]
        public string Code { get; set; }
        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<Instrument> Instrument { get; set; }

        public virtual ICollection<PartMPositionTolerance> PartMPositionTolerances { get; set; }

        public virtual ICollection<PartLPositionTolerance> PartLPositionTolerances { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }

    }
}
