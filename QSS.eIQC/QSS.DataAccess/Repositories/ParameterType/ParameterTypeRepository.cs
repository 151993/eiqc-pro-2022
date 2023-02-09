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
    public class ParameterTypeRepository : BaseRepository<ParameterType, int>, IParameterTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ParameterType into database
        /// </summary>
        /// <param name="ParameterType">New entity of ParameterType, <see cref="ParameterType"/></param>
        /// <returns>Saved entity of Role, <see cref="ParameterType"/></returns>
        public async Task<ParameterType> AddAsync(ParameterType parameterType, string changeReason)
        {
            return await AddAsync(parameterType, Constants.AuditLog.Title.AddParameterType(parameterType.Code), changeReason);
        }

        /// <summary>
        /// Updates existing ParameterType with new values
        /// </summary>
        /// <param name="ParameterType">Updated entity of ParameterType, <see cref="ParameterType"/></param>
        /// <returns>Saved entity of ParameterType, <see cref="ParameterType"/></returns>
        public async Task UpdateAsync(ParameterType parameterType, string changeReason)
        {
            await UpdateAsync(parameterType, Constants.AuditLog.Title.EditParameterType(parameterType.Code), changeReason);
        }

        /// <summary>
        /// Checks if the ParameterType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ParameterType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ParameterType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteParameterType(role.Code), changeReason);

            Remove(role);
        }
    }
}

