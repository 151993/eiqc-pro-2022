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
    public class FormResultOrientedParameterRepository : BaseRepository<FormResultOrientedParameter, int>, IFormResultOrientedParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormResultOrientedParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormResultOrientedParameter into database
        /// </summary>
        /// <param name="FormResultOrientedParameter">New entity of FormResultOrientedParameter, <see cref="FormResultOrientedParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormResultOrientedParameter"/></returns>
        public async Task<FormResultOrientedParameter> AddAsync(FormResultOrientedParameter formResultOrientedParameter, string changeReason)
        {
            return await AddAsync(formResultOrientedParameter, Constants.AuditLog.Title.AddFormResultOrientedParameter(formResultOrientedParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormResultOrientedParameter with new values
        /// </summary>
        /// <param name="FormResultOrientedParameter">Updated entity of FormResultOrientedParameter, <see cref="FormResultOrientedParameter"/></param>
        /// <returns>Saved entity of FormResultOrientedParameter, <see cref="FormResultOrientedParameter"/></returns>
        public async Task UpdateAsync(FormResultOrientedParameter formResultOrientedParameter, string changeReason)
        {
            await UpdateAsync(formResultOrientedParameter, Constants.AuditLog.Title.EditFormResultOrientedParameter(formResultOrientedParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormResultOrientedParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormResultOrientedParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormResultOrientedParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formResultOrientedParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formResultOrientedParameter, Constants.AuditLog.Title.DeleteFormResultOrientedParameter(formResultOrientedParameter.ParameterName), changeReason);

            Remove(formResultOrientedParameter);
        }
    }
}

