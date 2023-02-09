/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierMicrosectionRepository : BaseRepository<SupplierMicrosection, int>, ISupplierMicrosectionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierMicrosectionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierMicrosectionParameters.Count > 0)
            {
                var supplierMicrosectionParameterToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (supplierMicrosectionParameterToRemove != null)
                {
                    this.RemoveRange(supplierMicrosectionParameterToRemove);
                }
            }
            else if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierMicrosectionParameters != null && supplierMeasurementSubmission.SupplierMicrosectionParameters.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id));
            }
        }
    }
}

