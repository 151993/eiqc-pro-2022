/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class InspectionToolsRepository : BaseRepository<InspectionTools, int>, IInspectionToolsRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InspectionToolsRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new InspectionTools into database
        /// </summary>
        /// <param name="InspectionTools">New entity of InspectionTools, <see cref="InspectionTools"/></param>
        /// <returns>Saved entity of Role, <see cref="InspectionTools"/></returns>
        public async Task<InspectionTools> AddAsync(InspectionTools inspectionTools, string changeReason)
        {
            return await AddAsync(inspectionTools, Constants.AuditLog.Title.AddInspectionTools(inspectionTools.Name), changeReason);
        }

        /// <summary>
        /// Updates existing InspectionTools with new values
        /// </summary>
        /// <param name="InspectionTools">Updated entity of InspectionTools, <see cref="InspectionTools"/></param>
        /// <returns>Saved entity of InspectionTools, <see cref="InspectionTools"/></returns>
        public async Task UpdateAsync(InspectionTools inspectionTools, string changeReason)
        {
            await UpdateAsync(inspectionTools, Constants.AuditLog.Title.EditInspectionTools(inspectionTools.Name), changeReason);
        }

        /// <summary>
        /// Checks if the InspectionTools with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">InspectionTools Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed InspectionTools, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var inspectionTools = await ValidateExistsAndGetAsync(id);

            SetAuditLog(inspectionTools, Constants.AuditLog.Title.DeleteInspectionTools(inspectionTools.Name), changeReason);

            Remove(inspectionTools);
        }
    }
}

