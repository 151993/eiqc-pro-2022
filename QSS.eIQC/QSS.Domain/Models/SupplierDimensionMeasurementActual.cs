/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartMicrosection entity model to map database PartMicrosection table 
    /// </summary>
    public class SupplierDimensionMeasurementActual : PersistentObjectWithUpdate<int>
    {
        public SupplierDimensionMeasurementActual()
        {
        }
        public int SupplierDimensionMeasurementId { get; set; }

        public virtual SupplierDimensionMeasurement SupplierDimensionMeasurement { get; set; }

        public string ActualTextName { get; set; }

        public string ActualTextValue { get; set; }

    }
}
