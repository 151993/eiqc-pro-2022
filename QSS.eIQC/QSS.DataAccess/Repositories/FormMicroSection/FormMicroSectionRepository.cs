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
    public class FormMicroSectionRepository : BaseRepository<FormMicroSection, int>, IFormMicroSectionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormMicroSectionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormMicroSection into database
        /// </summary>
        /// <param name="FormMicroSection">New entity of FormMicroSection, <see cref="FormMicroSection"/></param>
        /// <returns>Saved entity of Role, <see cref="FormMicroSection"/></returns>
        public async Task<FormMicroSection> AddAsync(FormMicroSection formMicroSection, string changeReason)
        {
            return await AddAsync(formMicroSection, Constants.AuditLog.Title.AddFormMicroSection(formMicroSection.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormMicroSection with new values
        /// </summary>
        /// <param name="FormMicroSection">Updated entity of FormMicroSection, <see cref="FormMicroSection"/></param>
        /// <returns>Saved entity of FormMicroSection, <see cref="FormMicroSection"/></returns>
        public async Task UpdateAsync(FormMicroSection formMicroSection, string changeReason)
        {
            await UpdateAsync(formMicroSection, Constants.AuditLog.Title.EditFormMicroSection(formMicroSection.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormMicroSection with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormMicroSection Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormMicroSection, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formMicroSection = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formMicroSection, Constants.AuditLog.Title.DeleteFormMicroSection(formMicroSection.ParameterName), changeReason);

            Remove(formMicroSection);
        }
    }
}

