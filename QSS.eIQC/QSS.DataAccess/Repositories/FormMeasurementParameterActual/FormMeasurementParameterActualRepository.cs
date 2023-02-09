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
    public class FormMeasurementParameterActualRepository : BaseRepository<FormMeasurementParameterActual, int>, IFormMeasurementParameterActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMeasurementParameterActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMeasurementParameterActual into database
        /// </summary>
        /// <param name="FormMeasurementParameterActual">New entity of FormMeasurementParameterActual, <see cref="FormMeasurementParameterActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMeasurementParameterActual"/></returns>
        public async Task<FormMeasurementParameterActual> AddAsync(FormMeasurementParameterActual formMeasurementParameterActual, string changeReason)
        {
            return await AddAsync(formMeasurementParameterActual, Constants.AuditLog.Title.AddFormMeasurementParameterActual(formMeasurementParameterActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormMeasurementParameterActual with new values
        /// </summary>
        /// <param name="FormMeasurementParameterActual">Updated entity of FormMeasurementParameterActual, <see cref="FormMeasurementParameterActual"/></param>
        /// <returns>Saved entity of FormMeasurementParameterActual, <see cref="FormMeasurementParameterActual"/></returns>
        public async Task UpdateAsync(FormMeasurementParameterActual formMeasurementParameterActual, string changeReason)
        {
            await UpdateAsync(formMeasurementParameterActual, Constants.AuditLog.Title.EditFormMeasurementParameterActual(formMeasurementParameterActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormMeasurementParameterActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMeasurementParameterActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMeasurementParameterActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMeasurementParameterActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMeasurementParameterActual, Constants.AuditLog.Title.DeleteFormMeasurementParameterActual(formMeasurementParameterActual.ParameterName), changeReason);

            Remove(formMeasurementParameterActual);
        }
    }
}

