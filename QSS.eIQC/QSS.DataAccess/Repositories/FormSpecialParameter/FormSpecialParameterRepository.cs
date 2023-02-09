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
    public class FormSpecialParameterRepository : BaseRepository<FormSpecialParameter, int>, IFormSpecialParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormSpecialParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormSpecialParameter into database
        /// </summary>
        /// <param name="FormSpecialParameter">New entity of FormSpecialParameter, <see cref="FormSpecialParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormSpecialParameter"/></returns>
        public async Task<FormSpecialParameter> AddAsync(FormSpecialParameter FormSpecialParameter, string changeReason)
        {
            return await AddAsync(FormSpecialParameter, Constants.AuditLog.Title.AddFormSpecialParameter(FormSpecialParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormSpecialParameter with new values
        /// </summary>
        /// <param name="FormSpecialParameter">Updated entity of FormSpecialParameter, <see cref="FormSpecialParameter"/></param>
        /// <returns>Saved entity of FormSpecialParameter, <see cref="FormSpecialParameter"/></returns>
        public async Task UpdateAsync(FormSpecialParameter FormSpecialParameter, string changeReason)
        {
            await UpdateAsync(FormSpecialParameter, Constants.AuditLog.Title.EditFormSpecialParameter(FormSpecialParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormSpecialParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormSpecialParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormSpecialParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var FormSpecialParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(FormSpecialParameter, Constants.AuditLog.Title.DeleteFormSpecialParameter(FormSpecialParameter.ParameterName), changeReason);

            Remove(FormSpecialParameter);
        }
    }
}

