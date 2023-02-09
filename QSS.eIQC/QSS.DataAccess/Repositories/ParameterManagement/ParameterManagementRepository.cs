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
    public class ParameterManagementRepository : BaseRepository<ParameterManagement, int>, IParameterManagementRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterManagementRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ParameterManagement into database
        /// </summary>
        /// <param name="ParameterManagement">New entity of ParameterManagement, <see cref="ParameterManagement"/></param>
        /// <returns>Saved entity of Role, <see cref="ParameterManagement"/></returns>
        public async Task<ParameterManagement> AddAsync(ParameterManagement parameterManagement, string changeReason)
        {
            return await AddAsync(parameterManagement, Constants.AuditLog.Title.AddParameterManagement(parameterManagement.Name), changeReason);
        }

        /// <summary>
        /// Updates existing ParameterManagement with new values
        /// </summary>
        /// <param name="ParameterManagement">Updated entity of ParameterManagement, <see cref="ParameterManagement"/></param>
        /// <returns>Saved entity of ParameterManagement, <see cref="ParameterManagement"/></returns>
        public async Task UpdateAsync(ParameterManagement parameterManagement, string changeReason)
        {
            await UpdateAsync(parameterManagement, Constants.AuditLog.Title.EditParameterManagement(parameterManagement.Name), changeReason);
        }

        /// <summary>
        /// Checks if the ParameterManagement with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ParameterManagement Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ParameterManagement, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var parameterManagement = await ValidateExistsAndGetAsync(id);

            SetAuditLog(parameterManagement, Constants.AuditLog.Title.DeleteParameterManagement(parameterManagement.Name), changeReason);

            Remove(parameterManagement);
        }
    }
}

