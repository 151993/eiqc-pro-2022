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
    public class SupplierFormPackagingRepository : BaseRepository<SupplierFormPackaging, int>, ISupplierFormPackagingRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormPackagingRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormPackaging into database
        /// </summary>
        /// <param name="SupplierFormPackaging">New entity of SupplierFormPackaging, <see cref="SupplierFormPackaging"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormPackaging"/></returns>
        public async Task<SupplierFormPackaging> AddAsync(SupplierFormPackaging supplierFormPackaging, string changeReason)
        {
            return await AddAsync(supplierFormPackaging, Constants.AuditLog.Title.AddSupplierFormPackaging(supplierFormPackaging.ResultDesc), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormPackaging with new values
        /// </summary>
        /// <param name="SupplierFormPackaging">Updated entity of SupplierFormPackaging, <see cref="SupplierFormPackaging"/></param>
        /// <returns>Saved entity of SupplierFormPackaging, <see cref="SupplierFormPackaging"/></returns>
        public async Task UpdateAsync(SupplierFormPackaging supplierFormPackaging, string changeReason)
        {
            await UpdateAsync(supplierFormPackaging, Constants.AuditLog.Title.EditSupplierFormPackaging(supplierFormPackaging.ResultDesc), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormPackaging with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormPackaging Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormPackaging, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormPackaging(role.ResultDesc), changeReason);

            Remove(role);
        }
    }
}

