/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierDimensionMeasurementRepository : BaseRepository<SupplierDimensionMeasurement, int>, ISupplierDimensionMeasurementRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierDimensionMeasurementRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierDimensionMeasurements.Count > 0)
            {
                var supplierDimensionMeasurementToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (supplierDimensionMeasurementToRemove != null)
                {
                    this.RemoveRange(supplierDimensionMeasurementToRemove);
                }
            }
            else if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierDimensionMeasurements != null && supplierMeasurementSubmission.SupplierDimensionMeasurements.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id));
            }
        }
    }
}

