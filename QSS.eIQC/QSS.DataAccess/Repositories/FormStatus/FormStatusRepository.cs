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
    public class FormStatusRepository : BaseRepository<FormStatus, int>, IFormStatusRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormStatusRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormStatus into database
        /// </summary>
        /// <param name="FormStatus">New entity of FormStatus, <see cref="FormStatus"/></param>
        /// <returns>Saved entity of Role, <see cref="FormStatus"/></returns>
        public async Task<FormStatus> AddAsync(FormStatus FormStatus, string changeReason)
        {
            return await AddAsync(FormStatus, Constants.AuditLog.Title.AddFormStatus(FormStatus.UserName), changeReason);
        }

        /// <summary>
        /// Updates existing FormStatus with new values
        /// </summary>
        /// <param name="FormStatus">Updated entity of FormStatus, <see cref="FormStatus"/></param>
        /// <returns>Saved entity of FormStatus, <see cref="FormStatus"/></returns>
        public async Task UpdateAsync(FormStatus FormStatus, string changeReason)
        {
            await UpdateAsync(FormStatus, Constants.AuditLog.Title.EditFormStatus(FormStatus.UserName), changeReason);
        }

        /// <summary>
        /// Checks if the FormStatus with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormStatus Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormStatus, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var FormStatus = await ValidateExistsAndGetAsync(id);

            SetAuditLog(FormStatus, Constants.AuditLog.Title.DeleteFormStatus(FormStatus.UserName), changeReason);

            Remove(FormStatus);
        }
    }
}

