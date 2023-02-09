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
    public class SupplierFormMPositionRepository : BaseRepository<SupplierFormMPosition, int>, ISupplierFormMPositionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMPositionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMPosition into database
        /// </summary>
        /// <param name="SupplierFormMPosition">New entity of SupplierFormMPosition, <see cref="SupplierFormMPosition"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMPosition"/></returns>
        public async Task<SupplierFormMPosition> AddAsync(SupplierFormMPosition supplierFormMPosition, string changeReason)
        {
            return await AddAsync(supplierFormMPosition, Constants.AuditLog.Title.AddSupplierFormMPosition(supplierFormMPosition.ITCode), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMPosition with new values
        /// </summary>
        /// <param name="SupplierFormMPosition">Updated entity of SupplierFormMPosition, <see cref="SupplierFormMPosition"/></param>
        /// <returns>Saved entity of SupplierFormMPosition, <see cref="SupplierFormMPosition"/></returns>
        public async Task UpdateAsync(SupplierFormMPosition supplierFormMPosition, string changeReason)
        {
            await UpdateAsync(supplierFormMPosition, Constants.AuditLog.Title.EditSupplierFormMPosition(supplierFormMPosition.ITCode), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMPosition with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMPosition Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMPosition, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMPosition(role.ITCode), changeReason);

            Remove(role);
        }
    }
}

