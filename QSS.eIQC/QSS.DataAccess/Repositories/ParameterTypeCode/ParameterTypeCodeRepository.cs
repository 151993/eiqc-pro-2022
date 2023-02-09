
﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class ParameterTypeCodeRepository : BaseRepository<ParameterTypeCode, int>, IParameterTypeCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterTypeCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ParameterTypeCode into database
        /// </summary>
        /// <param name="ParameterTypeCode">New entity of ParameterTypeCode, <see cref="ParameterTypeCode"/></param>
        /// <returns>Saved entity of Role, <see cref="ParameterTypeCode"/></returns>
        public async Task<ParameterTypeCode> AddAsync(ParameterTypeCode parameterTypeCode, string changeReason)
        {
            return await AddAsync(parameterTypeCode, Constants.AuditLog.Title.AddParameterTypeCode(parameterTypeCode.Description), changeReason);
        }

        /// <summary>
        /// Updates existing ParameterTypeCode with new values
        /// </summary>
        /// <param name="ParameterTypeCode">Updated entity of ParameterTypeCode, <see cref="ParameterTypeCode"/></param>
        /// <returns>Saved entity of ParameterTypeCode, <see cref="ParameterTypeCode"/></returns>
        public async Task UpdateAsync(ParameterTypeCode parameterTypeCode, string changeReason)
        {
            await UpdateAsync(parameterTypeCode, Constants.AuditLog.Title.EditParameterTypeCode(parameterTypeCode.Description), changeReason);
        }

        /// <summary>
        /// Checks if the ParameterTypeCode with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ParameterTypeCode Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ParameterTypeCode, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var parameterTypeCode = await ValidateExistsAndGetAsync(id);

            SetAuditLog(parameterTypeCode, Constants.AuditLog.Title.DeleteParameterTypeCode(parameterTypeCode.Description), changeReason);

            Remove(parameterTypeCode);
        }
    }
}

