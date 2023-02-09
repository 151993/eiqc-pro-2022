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
    public class FormVISRepository : BaseRepository<FormVIS, int>, IFormVISRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormVISRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormVIS into database
        /// </summary>
        /// <param name="FormVIS">New entity of FormVIS, <see cref="FormVIS"/></param>
        /// <returns>Saved entity of Role, <see cref="FormVIS"/></returns>
        public async Task<FormVIS> AddAsync(FormVIS formVIS, string changeReason)
        {
            return await AddAsync(formVIS, Constants.AuditLog.Title.AddFormVIS("formVIS"), changeReason);
        }

        /// <summary>
        /// Updates existing FormVIS with new values
        /// </summary>
        /// <param name="FormVIS">Updated entity of FormVIS, <see cref="FormVIS"/></param>
        /// <returns>Saved entity of FormVIS, <see cref="FormVIS"/></returns>
        public async Task UpdateAsync(FormVIS formVIS, string changeReason)
        {
            await UpdateAsync(formVIS, Constants.AuditLog.Title.EditFormVIS("formVIS"), changeReason);
        }

        /// <summary>
        /// Checks if the FormVIS with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormVIS Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormVIS, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formVIS = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formVIS, Constants.AuditLog.Title.DeleteFormVIS("formVIS"), changeReason);

            Remove(formVIS);
        }
    }
}

