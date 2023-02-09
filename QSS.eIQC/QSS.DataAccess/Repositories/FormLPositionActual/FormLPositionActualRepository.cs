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
    public class FormLPositionActualRepository : BaseRepository<FormLPositionActual, int>, IFormLPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormLPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormLPositionActual into database
        /// </summary>
        /// <param name="FormLPositionActual">New entity of FormLPositionActual, <see cref="FormLPositionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormLPositionActual"/></returns>
        public async Task<FormLPositionActual> AddAsync(FormLPositionActual formLPositionActual, string changeReason)
        {
            return await AddAsync(formLPositionActual, Constants.AuditLog.Title.AddFormLPositionActual(formLPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Updates existing FormLPositionActual with new values
        /// </summary>
        /// <param name="FormLPositionActual">Updated entity of FormLPositionActual, <see cref="FormLPositionActual"/></param>
        /// <returns>Saved entity of FormLPositionActual, <see cref="FormLPositionActual"/></returns>
        public async Task UpdateAsync(FormLPositionActual formLPositionActual, string changeReason)
        {
            await UpdateAsync(formLPositionActual, Constants.AuditLog.Title.EditFormLPositionActual(formLPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Checks if the FormLPositionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormLPositionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormLPositionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formLPositionActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formLPositionActual, Constants.AuditLog.Title.DeleteFormLPositionActual(formLPositionActual.LineNo), changeReason);

            Remove(formLPositionActual);
        }
    }
}

