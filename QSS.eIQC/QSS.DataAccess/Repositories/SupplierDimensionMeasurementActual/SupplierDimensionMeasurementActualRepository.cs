using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for SupplierBowTwistDefectType, provides Add, Update and Delete operations
    /// </summary>
    public class SupplierDimensionMeasurementActualRepository : BaseRepository<SupplierDimensionMeasurementActual, int>, ISupplierDimensionMeasurementActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierDimensionMeasurementActualRepository(QSSContext context) : base(context)
        {
        }

        public void AddSupplierDimensionMeasurementActuals(SupplierDimensionMeasurement supplierDimensionMeasurement, IEnumerable<SupplierDimensionMeasurementActual> supplierDimensionMeasurementActuals)
        {
            supplierDimensionMeasurement.SupplierDimensionMeasurementActuals.Clear();
            if (supplierDimensionMeasurementActuals != null && supplierDimensionMeasurementActuals.Count() > 0)
            {
                AddRange(supplierDimensionMeasurementActuals.Select(r =>
                   new SupplierDimensionMeasurementActual()
                   {
                       SupplierDimensionMeasurement = supplierDimensionMeasurement,
                       ActualTextName = r.ActualTextName,
                       ActualTextValue = r.ActualTextValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierDimensionMeasurement supplierDimensionMeasurement)
        {
            if (supplierDimensionMeasurement.Id != 0 && supplierDimensionMeasurement.SupplierDimensionMeasurementActuals.Count > 0)
            {
                var supplierDimensionMeasurementRemove = this.Find(m => m.SupplierDimensionMeasurementId == supplierDimensionMeasurement.Id);
                if (supplierDimensionMeasurementRemove != null)
                {
                    this.RemoveRange(supplierDimensionMeasurementRemove);
                }
            }
            else if (supplierDimensionMeasurement.Id != 0 && supplierDimensionMeasurement.SupplierDimensionMeasurementActuals != null && supplierDimensionMeasurement.SupplierDimensionMeasurementActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierDimensionMeasurementId == supplierDimensionMeasurement.Id));
            }
        }
    }
}
