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
    public class CertificateTypeRepository : BaseRepository<CertificateType, int>, ICertificateTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CertificateTypeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new CertificateType into database
        /// </summary>
        /// <param name="CertificateType">New entity of CertificateType, <see cref="CertificateType"/></param>
        /// <returns>Saved entity of Role, <see cref="CertificateType"/></returns>
        public async Task<CertificateType> AddAsync(CertificateType certificateType, string changeReason)
        {
            return await AddAsync(certificateType, Constants.AuditLog.Title.AddCertificateType(certificateType.Name), changeReason);
        }

        /// <summary>
        /// Updates existing CertificateType with new values
        /// </summary>
        /// <param name="CertificateType">Updated entity of CertificateType, <see cref="CertificateType"/></param>
        /// <returns>Saved entity of CertificateType, <see cref="CertificateType"/></returns>
        public async Task<CertificateType> UpdateAsync(CertificateType certificateType, string changeReason)
        {
            return await UpdateAsync(certificateType, Constants.AuditLog.Title.EditCertificateType(certificateType.Name), changeReason);
        }

        /// <summary>
        /// Checks if the CertificateType with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">CertificateType Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed CertificateType, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var certificateType = await ValidateExistsAndGetAsync(id);

            SetAuditLog(certificateType, Constants.AuditLog.Title.DeleteCertificateType(certificateType.Name), changeReason);

            return Remove(certificateType);
        }
    }
}

