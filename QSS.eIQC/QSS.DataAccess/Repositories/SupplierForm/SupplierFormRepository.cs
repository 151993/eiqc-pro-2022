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
    public class SupplierFormRepository : BaseRepository<SupplierForm, int>, ISupplierFormRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierForm into database
        /// </summary>
        /// <param name="SupplierForm">New entity of SupplierForm, <see cref="SupplierForm"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierForm"/></returns>
        public async Task<SupplierForm> AddAsync(SupplierForm supplierForm, string changeReason)
        {
            return await AddAsync(supplierForm, Constants.AuditLog.Title.AddSupplierForm(supplierForm.PartNo), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierForm with new values
        /// </summary>
        /// <param name="SupplierForm">Updated entity of SupplierForm, <see cref="SupplierForm"/></param>
        /// <returns>Saved entity of SupplierForm, <see cref="SupplierForm"/></returns>
        public async Task UpdateAsync(SupplierForm supplierForm, string changeReason)
        {
            await UpdateAsync(supplierForm, Constants.AuditLog.Title.EditSupplierForm(supplierForm.PartNo), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierForm with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierForm Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierForm, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierForm(role.PartNo), changeReason);

            Remove(role);
        }
    }
}

