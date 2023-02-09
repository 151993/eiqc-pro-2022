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
    public class CTParameterRepository : BaseRepository<CTParameter, int>, ICTParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CTParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new CTParameter into database
        /// </summary>
        /// <param name="CTParameter">New entity of CTParameter, <see cref="CTParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="CTParameter"/></returns>
        public async Task<CTParameter> AddAsync(CTParameter cTParameter, string changeReason)
        {
            return await AddAsync(cTParameter, Constants.AuditLog.Title.AddCTParameter(cTParameter.Name), changeReason);
        }

        /// <summary>
        /// Updates existing CTParameter with new values
        /// </summary>
        /// <param name="CTParameter">Updated entity of CTParameter, <see cref="CTParameter"/></param>
        /// <returns>Saved entity of CTParameter, <see cref="CTParameter"/></returns>
        public async Task UpdateAsync(CTParameter cTParameter, string changeReason)
        {
            await UpdateAsync(cTParameter, Constants.AuditLog.Title.EditCTParameter(cTParameter.Name), changeReason);
        }

        /// <summary>
        /// Checks if the CTParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">CTParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed CTParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteCTParameter(role.Name), changeReason);

            Remove(role);
        }
    }
}

