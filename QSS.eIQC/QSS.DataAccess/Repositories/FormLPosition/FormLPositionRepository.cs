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
    public class FormLPositionRepository : BaseRepository<FormLPosition, int>, IFormLPositionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormLPositionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormLPosition into database
        /// </summary>
        /// <param name="FormLPosition">New entity of FormLPosition, <see cref="FormLPosition"/></param>
        /// <returns>Saved entity of Role, <see cref="FormLPosition"/></returns>
        public async Task<FormLPosition> AddAsync(FormLPosition formLPosition, string changeReason)
        {
            return await AddAsync(formLPosition, Constants.AuditLog.Title.AddFormLPosition(formLPosition.LineNo), changeReason);
        }

        /// <summary>
        /// Updates existing FormLPosition with new values
        /// </summary>
        /// <param name="FormLPosition">Updated entity of FormLPosition, <see cref="FormLPosition"/></param>
        /// <returns>Saved entity of FormLPosition, <see cref="FormLPosition"/></returns>
        public async Task UpdateAsync(FormLPosition formLPosition, string changeReason)
        {
            await UpdateAsync(formLPosition, Constants.AuditLog.Title.EditFormLPosition(formLPosition.LineNo), changeReason);
        }

        /// <summary>
        /// Checks if the FormLPosition with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormLPosition Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormLPosition, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formLPosition = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formLPosition, Constants.AuditLog.Title.DeleteFormLPosition(formLPosition.LineNo), changeReason);

            Remove(formLPosition);
        }
    }
}

