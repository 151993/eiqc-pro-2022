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
    public class InstrumentRepository : BaseRepository<Instrument, int>, IInstrumentRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InstrumentRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Instrument into database
        /// </summary>
        /// <param name="Instrument">New entity of Instrument, <see cref="Instrument"/></param>
        /// <returns>Saved entity of Role, <see cref="Instrument"/></returns>
        public async Task<Instrument> AddAsync(Instrument instrument, string changeReason)
        {
            return await AddAsync(instrument, Constants.AuditLog.Title.AddInstrument("instrument"), changeReason);
        }

        /// <summary>
        /// Updates existing Instrument with new values
        /// </summary>
        /// <param name="Instrument">Updated entity of Instrument, <see cref="Instrument"/></param>
        /// <returns>Saved entity of Instrument, <see cref="Instrument"/></returns>
        public async Task UpdateAsync(Instrument instrument, string changeReason)
        {
            await UpdateAsync(instrument, Constants.AuditLog.Title.EditInstrument("instrument"), changeReason);
        }

        /// <summary>
        /// Checks if the Instrument with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Instrument Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Instrument, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var instrument = await ValidateExistsAndGetAsync(id);

            SetAuditLog(instrument, Constants.AuditLog.Title.DeleteInstrument("instrument"), changeReason);

            Remove(instrument);
        }
    }
}

