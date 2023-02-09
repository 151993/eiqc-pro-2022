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
    public class FormTestReportRepository : BaseRepository<FormTestReport, int>, IFormTestReportRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormTestReportRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormTestReport into database
        /// </summary>
        /// <param name="FormTestReport">New entity of FormTestReport, <see cref="FormTestReport"/></param>
        /// <returns>Saved entity of Role, <see cref="FormTestReport"/></returns>
        public async Task<FormTestReport> AddAsync(FormTestReport formTestReport, string changeReason)
        {
            return await AddAsync(formTestReport, Constants.AuditLog.Title.AddFormTestReport(formTestReport.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormTestReport with new values
        /// </summary>
        /// <param name="FormTestReport">Updated entity of FormTestReport, <see cref="FormTestReport"/></param>
        /// <returns>Saved entity of FormTestReport, <see cref="FormTestReport"/></returns>
        public async Task UpdateAsync(FormTestReport formTestReport, string changeReason)
        {
            await UpdateAsync(formTestReport, Constants.AuditLog.Title.EditFormTestReport(formTestReport.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormTestReport with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormTestReport Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormTestReport, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formTestReport = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formTestReport, Constants.AuditLog.Title.DeleteFormTestReport(formTestReport.ParameterName), changeReason);

            Remove(formTestReport);
        }
    }
}

