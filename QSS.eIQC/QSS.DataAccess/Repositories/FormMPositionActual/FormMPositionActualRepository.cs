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
    public class FormMPositionActualRepository : BaseRepository<FormMPositionActual, int>, IFormMPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMPositionActual into database
        /// </summary>
        /// <param name="FormMPositionActual">New entity of FormMPositionActual, <see cref="FormMPositionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMPositionActual"/></returns>
        public async Task<FormMPositionActual> AddAsync(FormMPositionActual formMPositionActual, string changeReason)
        {
            return await AddAsync(formMPositionActual, Constants.AuditLog.Title.AddFormMPositionActual(formMPositionActual.InstrumentID), changeReason);
        }

        /// <summary>
        /// Updates existing FormMPositionActual with new values
        /// </summary>
        /// <param name="FormMPositionActual">Updated entity of FormMPositionActual, <see cref="FormMPositionActual"/></param>
        /// <returns>Saved entity of FormMPositionActual, <see cref="FormMPositionActual"/></returns>
        public async Task UpdateAsync(FormMPositionActual formMPositionActual, string changeReason)
        {
            await UpdateAsync(formMPositionActual, Constants.AuditLog.Title.EditFormMPositionActual(formMPositionActual.InstrumentID), changeReason);
        }

        /// <summary>
        /// Checks if the FormMPositionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMPositionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMPositionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMPositionActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMPositionActual, Constants.AuditLog.Title.DeleteFormMPositionActual(formMPositionActual.InstrumentID), changeReason);

            Remove(formMPositionActual);
        }
    }
}

