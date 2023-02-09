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
    public class GRSSAPResultRepository : BaseRepository<GRSSAPResult, int>, IGRSSAPResultRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public GRSSAPResultRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new GRSSAPResult into database
        /// </summary>
        /// <param name="GRSSAPResult">New entity of GRSSAPResult, <see cref="GRSSAPResult"/></param>
        /// <returns>Saved entity of Role, <see cref="GRSSAPResult"/></returns>
        public async Task<GRSSAPResult> AddAsync(GRSSAPResult gRSSAPResult, string changeReason)
        {
            return await AddAsync(gRSSAPResult, Constants.AuditLog.Title.AddGRSSAPResult(gRSSAPResult.GRSNO), changeReason);
        }

        /// <summary>
        /// Updates existing GRSSAPResult with new values
        /// </summary>
        /// <param name="GRSSAPResult">Updated entity of GRSSAPResult, <see cref="GRSSAPResult"/></param>
        /// <returns>Saved entity of GRSSAPResult, <see cref="GRSSAPResult"/></returns>
        public async Task UpdateAsync(GRSSAPResult gRSSAPResult, string changeReason)
        {
            await UpdateAsync(gRSSAPResult, Constants.AuditLog.Title.EditGRSSAPResult(gRSSAPResult.GRSNO), changeReason);
        }

        /// <summary>
        /// Checks if the GRSSAPResult with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">GRSSAPResult Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed GRSSAPResult, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteGRSSAPResult(role.GRSNO), changeReason);

            Remove(role);
        }
    }
}

