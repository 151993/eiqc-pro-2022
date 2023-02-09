using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierDimensionMeasurementActualRepository
    {
        void AddSupplierDimensionMeasurementActuals(SupplierDimensionMeasurement supplierDimensionMeasurement, IEnumerable<SupplierDimensionMeasurementActual> supplierDimensionMeasurementActuals);

        void RemoveRange(SupplierDimensionMeasurement supplierDimensionMeasurement);
    }
}