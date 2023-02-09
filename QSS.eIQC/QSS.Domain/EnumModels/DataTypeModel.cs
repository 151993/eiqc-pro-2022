
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("DataType")]
    public class DataTypeModel : BaseEnum<DataType, int>
    {
        public bool IsEnabled { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }

    }
}
