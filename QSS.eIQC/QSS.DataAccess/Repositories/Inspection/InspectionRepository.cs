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
    public class InspectionRepository : BaseRepository<Inspection, int>, IInspectionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InspectionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Inspection into database
        /// </summary>
        /// <param name="Inspection">New entity of Inspection, <see cref="Inspection"/></param>
        /// <returns>Saved entity of Role, <see cref="Inspection"/></returns>
        public async Task<Inspection> AddAsync(Inspection inspection, string changeReason)
        {
            return await AddAsync(inspection, Constants.AuditLog.Title.AddInspection(inspection.InspectionResult), changeReason);
        }

        /// <summary>
        /// Updates existing Inspection with new values
        /// </summary>
        /// <param name="Inspection">Updated entity of Inspection, <see cref="Inspection"/></param>
        /// <returns>Saved entity of Inspection, <see cref="Inspection"/></returns>
        public async Task UpdateAsync(Inspection inspection, string changeReason)
        {
            await UpdateAsync(inspection, Constants.AuditLog.Title.EditInspection(inspection.InspectionResult), changeReason);
        }

        /// <summary>
        /// Checks if the Inspection with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Inspection Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Inspection, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var inspection = await ValidateExistsAndGetAsync(id);

            SetAuditLog(inspection, Constants.AuditLog.Title.DeleteInspection(inspection.InspectionResult), changeReason);

            Remove(inspection);
        }
    }
}

