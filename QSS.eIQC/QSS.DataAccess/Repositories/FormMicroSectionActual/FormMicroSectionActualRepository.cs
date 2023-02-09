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
    public class FormMicroSectionActualRepository : BaseRepository<FormMicroSectionActual, int>, IFormMicroSectionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMicroSectionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMicroSectionActual into database
        /// </summary>
        /// <param name="FormMicroSectionActual">New entity of FormMicroSectionActual, <see cref="FormMicroSectionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMicroSectionActual"/></returns>
        public async Task<FormMicroSectionActual> AddAsync(FormMicroSectionActual formMicroSectionActual, string changeReason)
        {
            return await AddAsync(formMicroSectionActual, Constants.AuditLog.Title.AddFormMicroSectionActual(formMicroSectionActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormMicroSectionActual with new values
        /// </summary>
        /// <param name="FormMicroSectionActual">Updated entity of FormMicroSectionActual, <see cref="FormMicroSectionActual"/></param>
        /// <returns>Saved entity of FormMicroSectionActual, <see cref="FormMicroSectionActual"/></returns>
        public async Task UpdateAsync(FormMicroSectionActual formMicroSectionActual, string changeReason)
        {
            await UpdateAsync(formMicroSectionActual, Constants.AuditLog.Title.EditFormMicroSectionActual(formMicroSectionActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormMicroSectionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMicroSectionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMicroSectionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMicroSectionActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMicroSectionActual, Constants.AuditLog.Title.DeleteFormMicroSectionActual(formMicroSectionActual.ParameterName), changeReason);

            Remove(formMicroSectionActual);
        }
    }
}

