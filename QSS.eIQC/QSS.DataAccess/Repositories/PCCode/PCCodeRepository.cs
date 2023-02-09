/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PCCodeRepository : BaseRepository<PCCode, int>, IPCCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PCCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PCCode into database
        /// </summary>
        /// <param name="PCCode">New entity of PCCode, <see cref="PCCode"/></param>
        /// <returns>Saved entity of Role, <see cref="PCCode"/></returns>
        public async Task<PCCode> AddAsync(PCCode pCCode, string changeReason)
        {
            return await AddAsync(pCCode, Constants.AuditLog.Title.AddPCCode(pCCode.Code), changeReason);
        }

        /// <summary>
        /// Updates existing PCCode with new values
        /// </summary>
        /// <param name="PCCode">Updated entity of PCCode, <see cref="PCCode"/></param>
        /// <returns>Saved entity of PCCode, <see cref="PCCode"/></returns>
        public async Task UpdateAsync(PCCode pCCode, string changeReason)
        {
            await UpdateAsync(pCCode, Constants.AuditLog.Title.EditPCCode(pCCode.Code), changeReason);
        }

        /// <summary>
        /// Checks if the PCCode with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PCCode Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PCCode, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var pcCode = await ValidateExistsAndGetAsync(id);

            SetAuditLog(pcCode, Constants.AuditLog.Title.DeletePCCode(pcCode.Code), changeReason);

            Remove(pcCode);
        }
    }
}

