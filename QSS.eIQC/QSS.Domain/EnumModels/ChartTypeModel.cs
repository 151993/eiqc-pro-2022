using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{

    [Table("ChartType")]
    public class ChartTypeModel : BaseEnum<ChartType, int>
    {
        public bool IsEnabled { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }

        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariableParameters { get; set; }

        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurementParameters { get; set; }
    }
}
