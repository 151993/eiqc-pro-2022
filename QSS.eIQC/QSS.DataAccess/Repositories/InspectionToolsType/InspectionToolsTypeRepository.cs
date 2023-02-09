/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class InspectionToolsTypeRepository : BaseRepository<InspectionToolsType, int>, IInspectionToolsTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InspectionToolsTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new InspectionToolsType into database
        /// </summary>
        /// <param name="InspectionToolsType">New entity of InspectionToolsType, <see cref="InspectionToolsType"/></param>
        /// <returns>Saved entity of Role, <see cref="InspectionToolsType"/></returns>
        public async Task<InspectionToolsType> AddAsync(InspectionToolsType inspectionToolsType, string changeReason)
        {
            return await AddAsync(inspectionToolsType, Constants.AuditLog.Title.AddInspectionToolsType(inspectionToolsType.Type), changeReason);
        }

        /// <summary>
        /// Updates existing InspectionToolsType with new values
        /// </summary>
        /// <param name="InspectionToolsType">Updated entity of InspectionToolsType, <see cref="InspectionToolsType"/></param>
        /// <returns>Saved entity of InspectionToolsType, <see cref="InspectionToolsType"/></returns>
        public async Task UpdateAsync(InspectionToolsType inspectionToolsType, string changeReason)
        {
            await UpdateAsync(inspectionToolsType, Constants.AuditLog.Title.EditInspectionToolsType(inspectionToolsType.Type), changeReason);
        }

        /// <summary>
        /// Checks if the InspectionToolsType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">InspectionToolsType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed InspectionToolsType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var inspectionToolsType = await ValidateExistsAndGetAsync(id);

            SetAuditLog(inspectionToolsType, Constants.AuditLog.Title.DeleteInspectionToolsType(inspectionToolsType.Type), changeReason);

            Remove(inspectionToolsType);
        }
    }
}

