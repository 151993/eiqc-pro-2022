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
    public class CompletedGRSRepository : BaseRepository<CompletedGRS, int>, ICompletedGRSRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CompletedGRSRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new CompletedGRS into database
        /// </summary>
        /// <param name="CompletedGRS">New entity of CompletedGRS, <see cref="CompletedGRS"/></param>
        /// <returns>Saved entity of Role, <see cref="CompletedGRS"/></returns>
        public async Task<CompletedGRS> AddAsync(CompletedGRS completedGRS, string changeReason)
        {
            return await AddAsync(completedGRS, Constants.AuditLog.Title.AddCompletedGRS(completedGRS.PartNo), changeReason);
        }

        /// <summary>
        /// Updates existing CompletedGRS with new values
        /// </summary>
        /// <param name="CompletedGRS">Updated entity of CompletedGRS, <see cref="CompletedGRS"/></param>
        /// <returns>Saved entity of CompletedGRS, <see cref="CompletedGRS"/></returns>
        public async Task UpdateAsync(CompletedGRS completedGRS, string changeReason)
        {
            await UpdateAsync(completedGRS, Constants.AuditLog.Title.EditCompletedGRS(completedGRS.PartNo), changeReason);
        }

        /// <summary>
        /// Checks if the CompletedGRS with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">CompletedGRS Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed CompletedGRS, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteCompletedGRS(role.PartNo), changeReason);

            Remove(role);
        }
    }
}

