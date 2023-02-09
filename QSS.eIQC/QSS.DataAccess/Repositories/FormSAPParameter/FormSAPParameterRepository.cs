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
    public class FormSAPParameterRepository : BaseRepository<FormSAPParameter, int>, IFormSAPParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormSAPParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormSAPParameter into database
        /// </summary>
        /// <param name="FormSAPParameter">New entity of FormSAPParameter, <see cref="FormSAPParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormSAPParameter"/></returns>
        public async Task<FormSAPParameter> AddAsync(FormSAPParameter FormSAPParameter, string changeReason)
        {
            return await AddAsync(FormSAPParameter, Constants.AuditLog.Title.AddFormSAPParameter(FormSAPParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormSAPParameter with new values
        /// </summary>
        /// <param name="FormSAPParameter">Updated entity of FormSAPParameter, <see cref="FormSAPParameter"/></param>
        /// <returns>Saved entity of FormSAPParameter, <see cref="FormSAPParameter"/></returns>
        public async Task UpdateAsync(FormSAPParameter FormSAPParameter, string changeReason)
        {
            await UpdateAsync(FormSAPParameter, Constants.AuditLog.Title.EditFormSAPParameter(FormSAPParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormSAPParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormSAPParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormSAPParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var FormSAPParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(FormSAPParameter, Constants.AuditLog.Title.DeleteFormSAPParameter(FormSAPParameter.ParameterName), changeReason);

            Remove(FormSAPParameter);
        }
    }
}

