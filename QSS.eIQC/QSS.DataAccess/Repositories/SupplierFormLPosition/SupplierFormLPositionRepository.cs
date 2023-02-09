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
    public class SupplierFormLPositionRepository : BaseRepository<SupplierFormLPosition, int>, ISupplierFormLPositionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormLPositionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormLPosition into database
        /// </summary>
        /// <param name="SupplierFormLPosition">New entity of SupplierFormLPosition, <see cref="SupplierFormLPosition"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormLPosition"/></returns>
        public async Task<SupplierFormLPosition> AddAsync(SupplierFormLPosition supplierFormLPosition, string changeReason)
        {
            return await AddAsync(supplierFormLPosition, Constants.AuditLog.Title.AddSupplierFormLPosition(supplierFormLPosition.ITCode), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormLPosition with new values
        /// </summary>
        /// <param name="SupplierFormLPosition">Updated entity of SupplierFormLPosition, <see cref="SupplierFormLPosition"/></param>
        /// <returns>Saved entity of SupplierFormLPosition, <see cref="SupplierFormLPosition"/></returns>
        public async Task UpdateAsync(SupplierFormLPosition supplierFormLPosition, string changeReason)
        {
            await UpdateAsync(supplierFormLPosition, Constants.AuditLog.Title.EditSupplierFormLPosition(supplierFormLPosition.ITCode), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormLPosition with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormLPosition Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormLPosition, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormLPosition(role.ITCode), changeReason);

            Remove(role);
        }
    }
}

