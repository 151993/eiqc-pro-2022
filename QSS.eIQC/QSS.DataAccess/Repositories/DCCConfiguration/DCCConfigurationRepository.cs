/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class DCCConfigurationRepository : BaseRepository<DCCConfiguration, int>, IDCCConfigurationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DCCConfigurationRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new DCCConfiguration into database
        /// </summary>
        /// <param name="DCCConfiguration">New entity of DCCConfiguration, <see cref="DCCConfiguration"/></param>
        /// <returns>Saved entity of Role, <see cref="DCCConfiguration"/></returns>
        public async Task<DCCConfiguration> AddAsync(DCCConfiguration dCCConfiguration, string changeReason)
        {
            return await AddAsync(dCCConfiguration, Constants.AuditLog.Title.AddDCCConfiguration(dCCConfiguration.SiteNo), changeReason);
        }

        /// <summary>
        /// Updates existing DCCConfiguration with new values
        /// </summary>
        /// <param name="DCCConfiguration">Updated entity of DCCConfiguration, <see cref="DCCConfiguration"/></param>
        /// <returns>Saved entity of DCCConfiguration, <see cref="DCCConfiguration"/></returns>
        public async Task<DCCConfiguration> UpdateAsync(DCCConfiguration dCCConfiguration, string changeReason)
        {
           return await UpdateAsync(dCCConfiguration, Constants.AuditLog.Title.EditDCCConfiguration(dCCConfiguration.SiteNo), changeReason);
        }

        /// <summary>
        /// Checks if the DCCConfiguration with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">DCCConfiguration Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed DCCConfiguration, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var dCCConfiguration = await ValidateExistsAndGetAsync(id);

            SetAuditLog(dCCConfiguration, Constants.AuditLog.Title.DeleteDCCConfiguration(dCCConfiguration.SiteNo), changeReason);

            return Remove(dCCConfiguration);
        }
    }
}

