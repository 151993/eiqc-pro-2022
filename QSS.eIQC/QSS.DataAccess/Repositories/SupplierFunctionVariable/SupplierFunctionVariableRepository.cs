/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierFunctionVariableRepository : BaseRepository<SupplierFunctionVariable, int>, ISupplierFunctionVariableRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFunctionVariableRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierFunctionVariables.Count > 0)
            {
                var supplierFunctionVariablesToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (supplierFunctionVariablesToRemove != null)
                {
                    this.RemoveRange(supplierFunctionVariablesToRemove);
                }
            }
            else if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierFunctionVariables!= null && supplierMeasurementSubmission.SupplierFunctionVariables.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id));
            }
        }
    }
}

