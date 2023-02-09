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
    public class FormPackagingRepository : BaseRepository<FormPackaging, int>, IFormPackagingRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormPackagingRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormPackaging into database
        /// </summary>
        /// <param name="FormPackaging">New entity of FormPackaging, <see cref="FormPackaging"/></param>
        /// <returns>Saved entity of Role, <see cref="FormPackaging"/></returns>
        public async Task<FormPackaging> AddAsync(FormPackaging formPackaging, string changeReason)
        {
            return await AddAsync(formPackaging, Constants.AuditLog.Title.AddFormPackaging(formPackaging.ResultDesc), changeReason);
        }

        /// <summary>
        /// Updates existing FormPackaging with new values
        /// </summary>
        /// <param name="FormPackaging">Updated entity of FormPackaging, <see cref="FormPackaging"/></param>
        /// <returns>Saved entity of FormPackaging, <see cref="FormPackaging"/></returns>
        public async Task UpdateAsync(FormPackaging formPackaging, string changeReason)
        {
            await UpdateAsync(formPackaging, Constants.AuditLog.Title.EditFormPackaging(formPackaging.ResultDesc), changeReason);
        }

        /// <summary>
        /// Checks if the FormPackaging with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormPackaging Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormPackaging, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formPackaging = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formPackaging, Constants.AuditLog.Title.DeleteFormPackaging(formPackaging.ResultDesc), changeReason);

            Remove(formPackaging);
        }
    }
}

