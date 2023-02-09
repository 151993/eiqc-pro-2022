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
    public class FormMPositionRepository : BaseRepository<FormMPosition, int>, IFormMPositionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMPositionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMPosition into database
        /// </summary>
        /// <param name="FormMPosition">New entity of FormMPosition, <see cref="FormMPosition"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMPosition"/></returns>
        public async Task<FormMPosition> AddAsync(FormMPosition formMPosition, string changeReason)
        {
            return await AddAsync(formMPosition, Constants.AuditLog.Title.AddFormMPosition(formMPosition.LineNo), changeReason);
        }

        /// <summary>
        /// Updates existing FormMPosition with new values
        /// </summary>
        /// <param name="FormMPosition">Updated entity of FormMPosition, <see cref="FormMPosition"/></param>
        /// <returns>Saved entity of FormMPosition, <see cref="FormMPosition"/></returns>
        public async Task UpdateAsync(FormMPosition formMPosition, string changeReason)
        {
            await UpdateAsync(formMPosition, Constants.AuditLog.Title.EditFormMPosition(formMPosition.LineNo), changeReason);
        }

        /// <summary>
        /// Checks if the FormMPosition with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMPosition Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMPosition, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMPosition = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMPosition, Constants.AuditLog.Title.DeleteFormMPosition(formMPosition.LineNo), changeReason);

            Remove(formMPosition);
        }
    }
}

