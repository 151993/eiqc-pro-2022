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
    public class UOMRepository : BaseRepository<UOM, int>, IUOMRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public UOMRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new UOM into database
        /// </summary>
        /// <param name="UOM">New entity of UOM, <see cref="UOM"/></param>
        /// <returns>Saved entity of Role, <see cref="UOM"/></returns>
        public async Task<UOM> AddAsync(UOM uOM, string changeReason)
        {
            return await AddAsync(uOM, Constants.AuditLog.Title.AddUOM(uOM.Name), changeReason);
        }

        /// <summary>
        /// Updates existing UOM with new values
        /// </summary>
        /// <param name="UOM">Updated entity of UOM, <see cref="UOM"/></param>
        /// <returns>Saved entity of UOM, <see cref="UOM"/></returns>
        public async Task UpdateAsync(UOM uOM, string changeReason)
        {
            await UpdateAsync(uOM, Constants.AuditLog.Title.EditUOM(uOM.Name), changeReason);
        }

        /// <summary>
        /// Checks if the UOM with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">UOM Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed UOM, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteUOM(role.Name), changeReason);

            Remove(role);
        }
    }
}

