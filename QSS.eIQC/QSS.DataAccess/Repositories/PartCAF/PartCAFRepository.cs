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
    public class PartCAFRepository : BaseRepository<PartCAF, int>, IPartCAFRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartCAFRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PartCAF into database
        /// </summary>
        /// <param name="PartCAF">New entity of PartCAF, <see cref="PartCAF"/></param>
        /// <returns>Saved entity of Role, <see cref="PartCAF"/></returns>
        public async Task<PartCAF> AddAsync(PartCAF partCAF, string changeReason)
        {
            return await AddAsync(partCAF, Constants.AuditLog.Title.AddPartCAF(partCAF.PartNo), changeReason);
        }

        /// <summary>
        /// Updates existing PartCAF with new values
        /// </summary>
        /// <param name="PartCAF">Updated entity of PartCAF, <see cref="PartCAF"/></param>
        /// <returns>Saved entity of PartCAF, <see cref="PartCAF"/></returns>
        public async Task UpdateAsync(PartCAF partCAF, string changeReason)
        {
            await UpdateAsync(partCAF, Constants.AuditLog.Title.EditPartCAF(partCAF.PartNo), changeReason);
        }

        /// <summary>
        /// Checks if the PartCAF with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PartCAF Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PartCAF, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeletePartCAF(role.PartNo), changeReason);

            Remove(role);
        }
    }
}

