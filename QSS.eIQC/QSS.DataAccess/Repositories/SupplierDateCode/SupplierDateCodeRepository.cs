/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierDateCodeRepository : BaseRepository<SupplierDateCode, int>, ISupplierDateCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierDateCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }


        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierDateCode != null)
            {
                var supplierDateCodeToRemove = this.Find(m => m.Id == supplierMeasurementSubmission.SupplierDateCodeId);
                if (supplierDateCodeToRemove != null)
                {
                    this.RemoveRange(supplierDateCodeToRemove);
                }
            }
        }
    }
}

