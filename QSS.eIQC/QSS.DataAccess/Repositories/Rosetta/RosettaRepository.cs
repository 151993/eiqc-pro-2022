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
    public class RosettaRepository : BaseRepository<Rosetta, int>, IRosettaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public RosettaRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Rosetta into database
        /// </summary>
        /// <param name="Rosetta">New entity of Rosetta, <see cref="Rosetta"/></param>
        /// <returns>Saved entity of Role, <see cref="Rosetta"/></returns>
        public async Task<Rosetta> AddAsync(Rosetta rosetta, string changeReason)
        {
            return await AddAsync(rosetta, Constants.AuditLog.Title.AddRosetta(rosetta.EN_US), changeReason);
        }

        /// <summary>
        /// Updates existing Rosetta with new values
        /// </summary>
        /// <param name="Rosetta">Updated entity of Rosetta, <see cref="Rosetta"/></param>
        /// <returns>Saved entity of Rosetta, <see cref="Rosetta"/></returns>
        public async Task UpdateAsync(Rosetta rosetta, string changeReason)
        {
            await UpdateAsync(rosetta, Constants.AuditLog.Title.EditRosetta(rosetta.EN_US), changeReason);
        }

        /// <summary>
        /// Checks if the Rosetta with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Rosetta Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Rosetta, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteRosetta(role.EN_US), changeReason);

            Remove(role);
        }
    }
}

