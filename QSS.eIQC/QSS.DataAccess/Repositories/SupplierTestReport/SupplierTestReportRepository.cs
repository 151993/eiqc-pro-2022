/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierTestReportRepository : BaseRepository<SupplierTestReport, int>, ISupplierTestReportRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierTestReportRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierTestReport into database
        /// </summary>
        /// <param name="SupplierTestReport">New entity of SupplierTestReport, <see cref="SupplierTestReport"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierTestReport"/></returns>
        public async Task<SupplierTestReport> AddAsync(SupplierTestReport SupplierTestReport, string changeReason)
        {
            return await AddAsync(SupplierTestReport, Constants.AuditLog.Title.AddSupplierTestReport(SupplierTestReport.Id), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierTestReport with new values
        /// </summary>
        /// <param name="SupplierTestReport">Updated entity of SupplierTestReport, <see cref="SupplierTestReport"/></param>
        /// <returns>Saved entity of SupplierTestReport, <see cref="SupplierTestReport"/></returns>
        public async Task UpdateAsync(SupplierTestReport SupplierTestReport, string changeReason)
        {
            await UpdateAsync(SupplierTestReport, Constants.AuditLog.Title.EditSupplierTestReport(SupplierTestReport.Id), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierTestReport with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierTestReport Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierTestReport, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierTestReport(role.Id), changeReason);

            Remove(role);
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierTestReports.Count > 0)
            {
                var partTestReportParametersrToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (partTestReportParametersrToRemove != null)
                {
                    this.RemoveRange(partTestReportParametersrToRemove);
                }
            }
        }
    }
}

