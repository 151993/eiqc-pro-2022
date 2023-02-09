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
    public class FormPartDateCodeRepository : BaseRepository<FormPartDateCode, int>, IFormPartDateCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormPartDateCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormPartDateCode into database
        /// </summary>
        /// <param name="FormPartDateCode">New entity of FormPartDateCode, <see cref="FormPartDateCode"/></param>
        /// <returns>Saved entity of Role, <see cref="FormPartDateCode"/></returns>
        public async Task<FormPartDateCode> AddAsync(FormPartDateCode formPartDateCode, string changeReason)
        {
            return await AddAsync(formPartDateCode, Constants.AuditLog.Title.AddFormPartDateCode(formPartDateCode.Requirement), changeReason);
        }

        /// <summary>
        /// Updates existing FormPartDateCode with new values
        /// </summary>
        /// <param name="FormPartDateCode">Updated entity of FormPartDateCode, <see cref="FormPartDateCode"/></param>
        /// <returns>Saved entity of FormPartDateCode, <see cref="FormPartDateCode"/></returns>
        public async Task UpdateAsync(FormPartDateCode formPartDateCode, string changeReason)
        {
            await UpdateAsync(formPartDateCode, Constants.AuditLog.Title.EditFormPartDateCode(formPartDateCode.Requirement), changeReason);
        }

        /// <summary>
        /// Checks if the FormPartDateCode with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormPartDateCode Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormPartDateCode, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formPartDateCode = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formPartDateCode, Constants.AuditLog.Title.DeleteFormPartDateCode(formPartDateCode.Requirement), changeReason);

            Remove(formPartDateCode);
        }
    }
}

