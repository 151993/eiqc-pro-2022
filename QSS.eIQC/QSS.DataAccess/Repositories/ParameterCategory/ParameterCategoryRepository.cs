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
    public class ParameterCategoryRepository : BaseRepository<ParameterCategory, int>, IParameterCategoryRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterCategoryRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ParameterCategory into database
        /// </summary>
        /// <param name="ParameterCategory">New entity of ParameterCategory, <see cref="ParameterCategory"/></param>
        /// <returns>Saved entity of Role, <see cref="ParameterCategory"/></returns>
        public async Task<ParameterCategory> AddAsync(ParameterCategory parameterCategory, string changeReason)
        {
            return await AddAsync(parameterCategory, Constants.AuditLog.Title.AddParameterCategory(parameterCategory.Description), changeReason);
        }

        /// <summary>
        /// Updates existing ParameterCategory with new values
        /// </summary>
        /// <param name="ParameterCategory">Updated entity of ParameterCategory, <see cref="ParameterCategory"/></param>
        /// <returns>Saved entity of ParameterCategory, <see cref="ParameterCategory"/></returns>
        public async Task UpdateAsync(ParameterCategory parameterCategory, string changeReason)
        {
            await UpdateAsync(parameterCategory, Constants.AuditLog.Title.EditParameterCategory(parameterCategory.Description), changeReason);
        }

        /// <summary>
        /// Checks if the ParameterCategory with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ParameterCategory Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ParameterCategory, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var parameterCategory = await ValidateExistsAndGetAsync(id);

            SetAuditLog(parameterCategory, Constants.AuditLog.Title.DeleteParameterCategory(parameterCategory.Description), changeReason);

            Remove(parameterCategory);
        }
    }
}

