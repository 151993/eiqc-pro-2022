/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SiteUserRepository : BaseRepository<SiteUser, int>, ISiteUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SiteUserRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SiteUser into database
        /// </summary>
        /// <param name="SiteUser">New entity of SiteUser, <see cref="SiteUser"/></param>
        /// <returns>Saved entity of SiteUser, <see cref="SiteUser"/></returns>
        public void AddSiteUsers(Site site, List<int> userIds, string changeReason)
        {
            if (userIds != null && userIds.IsAny())
            {
                AddRange(userIds.Select(r =>
                      new SiteUser()
                      {
                          SiteId = site.Id,
                          UserId = r,
                      }
                   ));
            }
        }       

        /// <summary>
        /// Checks if the SiteUser with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">Site Id</param>
        /// <param name="userIds">List of User Ids to be deleted</param>
        /// <returns>Returns instance of removed SiteUser, <see cref="SiteUser"/></returns>
        public void RemoveSiteUsers(Site site, List<int> userIds, string changeReason)
        {
            if (userIds != null && userIds.IsAny())
            {
                var siteUsers = Context.Set<SiteUser>()
                                .Where(s => s.SiteId == site.Id)
                                .Where(d => userIds.Contains(d.UserId))
                                .ToList();

                if (!siteUsers.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SiteUserDoesNotExists(site.Id));
                }

                RemoveRange(siteUsers);
            }
        }

        /// <summary>
        /// Updates existing Site with new values
        /// </summary>
        /// <param name="Site">Updated entity of Site, <see cref="Site"/></param>
        /// <returns>Saved entity of Site, <see cref="Site"/></returns>
        public void Update(SiteUser site, string siteName, string changeReason)
        {
            var siteUser = Get(site.Id).Result;
            siteUser.Status = siteUser.Status;

            SetAuditLog(siteUser, Constants.AuditLog.Title.DeleteSite(siteName), changeReason);

            Update(siteUser);
        }

        public async Task RemoveByIdAsync(int id, string siteName, string changeReason)
        {
            var siteUser = await ValidateExistsAndGetAsync(id);

            SetAuditLog(siteUser, Constants.AuditLog.Title.DeleteSite(siteName), changeReason);

            Remove(siteUser);
        }
    }
}

