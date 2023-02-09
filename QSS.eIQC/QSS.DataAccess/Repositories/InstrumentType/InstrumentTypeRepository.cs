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
    public class InstrumentTypeRepository : BaseRepository<InstrumentType, int>, IInstrumentTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InstrumentTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new InstrumentType into database
        /// </summary>
        /// <param name="InstrumentType">New entity of InstrumentType, <see cref="InstrumentType"/></param>
        /// <returns>Saved entity of Role, <see cref="InstrumentType"/></returns>
        public async Task<InstrumentType> AddAsync(InstrumentType instrumentType, string changeReason)
        {
            return await AddAsync(instrumentType, Constants.AuditLog.Title.AddInstrumentType(instrumentType.Code), changeReason);
        }

        /// <summary>
        /// Updates existing InstrumentType with new values
        /// </summary>
        /// <param name="InstrumentType">Updated entity of InstrumentType, <see cref="InstrumentType"/></param>
        /// <returns>Saved entity of InstrumentType, <see cref="InstrumentType"/></returns>
        public async Task UpdateAsync(InstrumentType instrumentType, string changeReason)
        {
            await UpdateAsync(instrumentType, Constants.AuditLog.Title.EditInstrumentType(instrumentType.Code), changeReason);
        }

        /// <summary>
        /// Checks if the InstrumentType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">InstrumentType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed InstrumentType, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteInstrumentType(role.Code), changeReason);

            Remove(role);
        }
    }
}

