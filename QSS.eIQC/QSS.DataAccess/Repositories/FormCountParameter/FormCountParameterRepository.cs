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
    public class FormCountParameterRepository : BaseRepository<FormCountParameter, int>, IFormCountParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormCountParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormCountParameter into database
        /// </summary>
        /// <param name="FormCountParameter">New entity of FormCountParameter, <see cref="FormCountParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormCountParameter"/></returns>
        public async Task<FormCountParameter> AddAsync(FormCountParameter formCountParameter, string changeReason)
        {
            return await AddAsync(formCountParameter, Constants.AuditLog.Title.AddFormCountParameter(formCountParameter.InspectionDetails), changeReason);
        }

        /// <summary>
        /// Updates existing FormCountParameter with new values
        /// </summary>
        /// <param name="FormCountParameter">Updated entity of FormCountParameter, <see cref="FormCountParameter"/></param>
        /// <returns>Saved entity of FormCountParameter, <see cref="FormCountParameter"/></returns>
        public async Task UpdateAsync(FormCountParameter formCountParameter, string changeReason)
        {
            await UpdateAsync(formCountParameter, Constants.AuditLog.Title.EditFormCountParameter(formCountParameter.InspectionDetails), changeReason);
        }

        /// <summary>
        /// Checks if the FormCountParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormCountParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormCountParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formCountParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formCountParameter, Constants.AuditLog.Title.DeleteFormCountParameter(formCountParameter.InspectionDetails), changeReason);

            Remove(formCountParameter);
        }
    }
}

