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
    public class FormTypeRepository : BaseRepository<FormType, int>, IFormTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormType into database
        /// </summary>
        /// <param name="FormType">New entity of FormType, <see cref="FormType"/></param>
        /// <returns>Saved entity of Role, <see cref="FormType"/></returns>
        public async Task<FormType> AddAsync(FormType formType, string changeReason)
        {
            return await AddAsync(formType, Constants.AuditLog.Title.AddFormType(formType.Type), changeReason);
        }

        /// <summary>
        /// Updates existing FormType with new values
        /// </summary>
        /// <param name="FormType">Updated entity of FormType, <see cref="FormType"/></param>
        /// <returns>Saved entity of FormType, <see cref="FormType"/></returns>
        public async Task UpdateAsync(FormType formType, string changeReason)
        {
            await UpdateAsync(formType, Constants.AuditLog.Title.EditFormType(formType.Type), changeReason);
        }

        /// <summary>
        /// Checks if the FormType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formType = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formType, Constants.AuditLog.Title.DeleteFormType(formType.Type), changeReason);

            Remove(formType);
        }
    }
}

