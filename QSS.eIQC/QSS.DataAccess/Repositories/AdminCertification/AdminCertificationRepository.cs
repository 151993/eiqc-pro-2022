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
    public class AdminCertificationRepository : BaseRepository<AdminCertification, int>, IAdminCertificationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public AdminCertificationRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new AdminCertification into database
        /// </summary>
        /// <param name="AdminCertification">New entity of AdminCertification, <see cref="AdminCertification"/></param>
        /// <returns>Saved entity of Role, <see cref="AdminCertification"/></returns>
        public async Task<AdminCertification> AddAsync(AdminCertification adminCertification, string changeReason)
        {
            return await AddAsync(adminCertification, Constants.AuditLog.Title.AddAdminCertification(adminCertification.Name), changeReason);
        }

        /// <summary>
        /// Updates existing AdminCertification with new values
        /// </summary>
        /// <param name="AdminCertification">Updated entity of AdminCertification, <see cref="AdminCertification"/></param>
        /// <returns>Saved entity of AdminCertification, <see cref="AdminCertification"/></returns>
        public async Task UpdateAsync(AdminCertification adminCertification, string changeReason)
        {
            await UpdateAsync(adminCertification, Constants.AuditLog.Title.EditAdminCertification(adminCertification.Name), changeReason);
        }

        /// <summary>
        /// Checks if the AdminCertification with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">AdminCertification Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed AdminCertification, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var adminCertification = await ValidateExistsAndGetAsync(id);

            SetAuditLog(adminCertification, Constants.AuditLog.Title.DeleteAdminCertification(adminCertification.Name), changeReason);

            Remove(adminCertification);
        }
    }
}

