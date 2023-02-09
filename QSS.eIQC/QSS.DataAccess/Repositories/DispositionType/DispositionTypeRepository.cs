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
    public class DispositionTypeRepository : BaseRepository<DispositionType, int>, IDispositionTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DispositionTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new DispositionType into database
        /// </summary>
        /// <param name="DispositionType">New entity of DispositionType, <see cref="DispositionType"/></param>
        /// <returns>Saved entity of Role, <see cref="DispositionType"/></returns>
        public async Task<DispositionType> AddAsync(DispositionType dispositionType, string changeReason)
        {
            return await AddAsync(dispositionType, Constants.AuditLog.Title.AddDispositionType(dispositionType.Description), changeReason);
        }

        /// <summary>
        /// Updates existing DispositionType with new values
        /// </summary>
        /// <param name="DispositionType">Updated entity of DispositionType, <see cref="DispositionType"/></param>
        /// <returns>Saved entity of DispositionType, <see cref="DispositionType"/></returns>
        public async Task UpdateAsync(DispositionType dispositionType, string changeReason)
        {
            await UpdateAsync(dispositionType, Constants.AuditLog.Title.EditDispositionType(dispositionType.Description), changeReason);
        }

        /// <summary>
        /// Checks if the DispositionType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">DispositionType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed DispositionType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteDispositionType(role.Description), changeReason);

            Remove(role);
        }
    }
}

