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
    public class FormRepository : BaseRepository<Form, int>, IFormRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Form into database
        /// </summary>
        /// <param name="Form">New entity of Form, <see cref="Form"/></param>
        /// <returns>Saved entity of Role, <see cref="Form"/></returns>
        public async Task<Form> AddAsync(Form form, string changeReason)
        {
            return await AddAsync(form, Constants.AuditLog.Title.AddForm(form.BatchDC), changeReason);
        }

        /// <summary>
        /// Updates existing Form with new values
        /// </summary>
        /// <param name="Form">Updated entity of Form, <see cref="Form"/></param>
        /// <returns>Saved entity of Form, <see cref="Form"/></returns>
        public async Task UpdateAsync(Form form, string changeReason)
        {
            await UpdateAsync(form, Constants.AuditLog.Title.EditForm(form.BatchDC), changeReason);
        }

        /// <summary>
        /// Checks if the Form with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Form Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Form, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var form = await ValidateExistsAndGetAsync(id);

            SetAuditLog(form, Constants.AuditLog.Title.DeleteForm(form.BatchDC), changeReason);

            Remove(form);
        }
    }
}

