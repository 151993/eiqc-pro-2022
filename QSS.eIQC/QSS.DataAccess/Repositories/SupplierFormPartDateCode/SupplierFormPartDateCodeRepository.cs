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
    public class SupplierFormPartDateCodeRepository : BaseRepository<SupplierFormPartDateCode, int>, ISupplierFormPartDateCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormPartDateCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormPartDateCode into database
        /// </summary>
        /// <param name="SupplierFormPartDateCode">New entity of SupplierFormPartDateCode, <see cref="SupplierFormPartDateCode"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormPartDateCode"/></returns>
        public async Task<SupplierFormPartDateCode> AddAsync(SupplierFormPartDateCode supplierFormPartDateCode, string changeReason)
        {
            return await AddAsync(supplierFormPartDateCode, Constants.AuditLog.Title.AddSupplierFormPartDateCode(supplierFormPartDateCode.Requirement), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormPartDateCode with new values
        /// </summary>
        /// <param name="SupplierFormPartDateCode">Updated entity of SupplierFormPartDateCode, <see cref="SupplierFormPartDateCode"/></param>
        /// <returns>Saved entity of SupplierFormPartDateCode, <see cref="SupplierFormPartDateCode"/></returns>
        public async Task UpdateAsync(SupplierFormPartDateCode supplierFormPartDateCode, string changeReason)
        {
            await UpdateAsync(supplierFormPartDateCode, Constants.AuditLog.Title.EditSupplierFormPartDateCode(supplierFormPartDateCode.Requirement), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormPartDateCode with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormPartDateCode Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormPartDateCode, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormPartDateCode(role.Requirement), changeReason);

            Remove(role);
        }
    }
}

