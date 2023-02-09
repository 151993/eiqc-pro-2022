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
    public class GRSRepository : BaseRepository<GRS, int>, IGRSRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public GRSRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new GRS into database
        /// </summary>
        /// <param name="GRS">New entity of GRS, <see cref="GRS"/></param>
        /// <returns>Saved entity of Role, <see cref="GRS"/></returns>
        public async Task<GRS> AddAsync(GRS gRS, string changeReason)
        {
            return await AddAsync(gRS, Constants.AuditLog.Title.AddGRS(gRS.InspectorName), changeReason);
        }

        /// <summary>
        /// Updates existing GRS with new values
        /// </summary>
        /// <param name="GRS">Updated entity of GRS, <see cref="GRS"/></param>
        /// <returns>Saved entity of GRS, <see cref="GRS"/></returns>
        public async Task UpdateAsync(GRS gRS, string changeReason)
        {
            await UpdateAsync(gRS, Constants.AuditLog.Title.EditGRS(gRS.InspectorName), changeReason);
        }

        /// <summary>
        /// Checks if the GRS with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">GRS Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed GRS, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var gRS = await ValidateExistsAndGetAsync(id);

            SetAuditLog(gRS, Constants.AuditLog.Title.DeleteGRS(gRS.InspectorName), changeReason);

            Remove(gRS);
        }
    }
}

