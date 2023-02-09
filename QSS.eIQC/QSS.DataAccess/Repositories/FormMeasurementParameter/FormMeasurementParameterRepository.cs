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
    public class FormMeasurementParameterRepository : BaseRepository<FormMeasurementParameter, int>, IFormMeasurementParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMeasurementParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMeasurementParameter into database
        /// </summary>
        /// <param name="FormMeasurementParameter">New entity of FormMeasurementParameter, <see cref="FormMeasurementParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMeasurementParameter"/></returns>
        public async Task<FormMeasurementParameter> AddAsync(FormMeasurementParameter formMeasurementParameter, string changeReason)
        {
            return await AddAsync(formMeasurementParameter, Constants.AuditLog.Title.AddFormMeasurementParameter(formMeasurementParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormMeasurementParameter with new values
        /// </summary>
        /// <param name="FormMeasurementParameter">Updated entity of FormMeasurementParameter, <see cref="FormMeasurementParameter"/></param>
        /// <returns>Saved entity of FormMeasurementParameter, <see cref="FormMeasurementParameter"/></returns>
        public async Task UpdateAsync(FormMeasurementParameter formMeasurementParameter, string changeReason)
        {
            await UpdateAsync(formMeasurementParameter, Constants.AuditLog.Title.EditFormMeasurementParameter(formMeasurementParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormMeasurementParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMeasurementParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMeasurementParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMeasurementParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMeasurementParameter, Constants.AuditLog.Title.DeleteFormMeasurementParameter(formMeasurementParameter.ParameterName), changeReason);

            Remove(formMeasurementParameter);
        }
    }
}

