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
    public class PCCodeInspectionToolsTypeRepository : BaseRepository<PCCodeInspectionToolsType, int>, IPCCodeInspectionToolsTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PCCodeInspectionToolsTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PCCodeInspectionToolsType into database
        /// </summary>
        /// <param name="PCCodeInspectionToolsType">New entity of PCCodeInspectionToolsType, <see cref="PCCodeInspectionToolsType"/></param>
        /// <returns>Saved entity of Role, <see cref="PCCodeInspectionToolsType"/></returns>
        public async Task<PCCodeInspectionToolsType> AddAsync(PCCodeInspectionToolsType pCCodeInspectionToolsType, string changeReason)
        {
            return await AddAsync(pCCodeInspectionToolsType, Constants.AuditLog.Title.AddPCCodeInspectionToolsType("pCCodeInspectionToolsType"), changeReason);
        }

        /// <summary>
        /// Updates existing PCCodeInspectionToolsType with new values
        /// </summary>
        /// <param name="PCCodeInspectionToolsType">Updated entity of PCCodeInspectionToolsType, <see cref="PCCodeInspectionToolsType"/></param>
        /// <returns>Saved entity of PCCodeInspectionToolsType, <see cref="PCCodeInspectionToolsType"/></returns>
        public async Task UpdateAsync(PCCodeInspectionToolsType pCCodeInspectionToolsType, string changeReason)
        {
            await UpdateAsync(pCCodeInspectionToolsType, Constants.AuditLog.Title.EditPCCodeInspectionToolsType("pCCodeInspectionToolsType"), changeReason);
        }

        /// <summary>
        /// Checks if the PCCodeInspectionToolsType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PCCodeInspectionToolsType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PCCodeInspectionToolsType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var pCCodeInspectionToolsType = await ValidateExistsAndGetAsync(id);

            SetAuditLog(pCCodeInspectionToolsType, Constants.AuditLog.Title.DeletePCCodeInspectionToolsType("pCCodeInspectionToolsType"), changeReason);

            Remove(pCCodeInspectionToolsType);
        }
    }
}

