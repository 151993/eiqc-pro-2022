/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartMicrosection entity model to map database PartMicrosection table 
    /// </summary>
    public class SupplierMicrosection : PersistentObjectWithUpdate<int>
    {
        public SupplierMicrosection()
        {
            this.SupplierMicroSectionActuals = new HashSet<SupplierMicroSectionActual>();
        }
        public double? NormalValue { get; set; }

        public double? UpperTolerance { get; set; }

        public double? LowerTolerance { get; set; }

        public int? Accuracy { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int ParameterManagementId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int? InstrumentId { get; set; }

        public int DataTypeId { get; set; }

        public int? ChartTypeId { get; set; }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual UOM UOM { get; set; }

        public virtual InstrumentType InstrumentType { get; set; }

        public virtual Instrument Instrument { get; set; }

        public virtual DataTypeModel DataType { get; set; }

        public virtual ChartTypeModel ChartType { get; set; }

        public virtual ICollection<SupplierMicroSectionActual> SupplierMicroSectionActuals { get; set; }
    }
}
