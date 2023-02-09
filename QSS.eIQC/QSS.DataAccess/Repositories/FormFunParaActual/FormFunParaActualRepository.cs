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
    public class FormFunParaActualRepository : BaseRepository<FormFunParaActual, int>, IFormFunParaActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormFunParaActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormFunParaActual into database
        /// </summary>
        /// <param name="FormFunParaActual">New entity of FormFunParaActual, <see cref="FormFunParaActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormFunParaActual"/></returns>
        public async Task<FormFunParaActual> AddAsync(FormFunParaActual formFunParaActual, string changeReason)
        {
            return await AddAsync(formFunParaActual, Constants.AuditLog.Title.AddFormFunParaActual(formFunParaActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormFunParaActual with new values
        /// </summary>
        /// <param name="FormFunParaActual">Updated entity of FormFunParaActual, <see cref="FormFunParaActual"/></param>
        /// <returns>Saved entity of FormFunParaActual, <see cref="FormFunParaActual"/></returns>
        public async Task UpdateAsync(FormFunParaActual formFunParaActual, string changeReason)
        {
            await UpdateAsync(formFunParaActual, Constants.AuditLog.Title.EditFormFunParaActual(formFunParaActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormFunParaActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormFunParaActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormFunParaActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formFunParaActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formFunParaActual, Constants.AuditLog.Title.DeleteFormFunParaActual(formFunParaActual.ParameterName), changeReason);

            Remove(formFunParaActual);
        }
    }
}

