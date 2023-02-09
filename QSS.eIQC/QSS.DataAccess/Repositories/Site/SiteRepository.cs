/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SiteRepository : BaseRepository<Site, int>, ISiteRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SiteRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Site into database
        /// </summary>
        /// <param name="Site">New entity of Site, <see cref="Site"/></param>
        /// <returns>Saved entity of Site, <see cref="Site"/></returns>
        public async Task<Site> AddAsync(Site site, string changeReason)
        {
            return await AddAsync(site, Constants.AuditLog.Title.AddSite(site.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Site with new values
        /// </summary>
        /// <param name="Site">Updated entity of Site, <see cref="Site"/></param>
        /// <returns>Saved entity of Site, <see cref="Site"/></returns>
        public async Task UpdateAsync(Site site, string changeReason)
        {
            await UpdateAsync(site, Constants.AuditLog.Title.EditSite(site.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Site with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Site, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var site = await ValidateExistsAndGetAsync(id);

            SetAuditLog(site, Constants.AuditLog.Title.DeleteSite(site.Name), changeReason);

            Remove(site);
        }
    }
}

