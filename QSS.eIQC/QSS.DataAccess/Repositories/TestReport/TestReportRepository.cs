/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class TestReportRepository : BaseRepository<TestReport, int>, ITestReportRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public TestReportRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new TestReport into database
        /// </summary>
        /// <param name="TestReport">New entity of TestReport, <see cref="TestReport"/></param>
        /// <returns>Saved entity of Role, <see cref="TestReport"/></returns>
        public async Task<TestReport> AddAsync(TestReport testReport, string changeReason)
        {
            return await AddAsync(testReport, Constants.AuditLog.Title.AddTestReport(testReport.Name), changeReason);
        }

        /// <summary>
        /// Updates existing TestReport with new values
        /// </summary>
        /// <param name="TestReport">Updated entity of TestReport, <see cref="TestReport"/></param>
        /// <returns>Saved entity of TestReport, <see cref="TestReport"/></returns>
        public async Task UpdateAsync(TestReport testReport, string changeReason)
        {
            await UpdateAsync(testReport, Constants.AuditLog.Title.EditTestReport(testReport.Name), changeReason);
        }

        /// <summary>
        /// Checks if the TestReport with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">TestReport Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed TestReport, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var testReport = await ValidateExistsAndGetAsync(id);

            SetAuditLog(testReport, Constants.AuditLog.Title.DeleteTestReport(testReport.Name), changeReason);

            Remove(testReport);
        }
    }
}

