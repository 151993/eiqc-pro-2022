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
    public class SupplierFormMPositionActualRepository : BaseRepository<SupplierFormMPositionActual, int>, ISupplierFormMPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMPositionActual into database
        /// </summary>
        /// <param name="SupplierFormMPositionActual">New entity of SupplierFormMPositionActual, <see cref="SupplierFormMPositionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMPositionActual"/></returns>
        public async Task<SupplierFormMPositionActual> AddAsync(SupplierFormMPositionActual supplierFormMPositionActual, string changeReason)
        {
            return await AddAsync(supplierFormMPositionActual, Constants.AuditLog.Title.AddSupplierFormMPositionActual(supplierFormMPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMPositionActual with new values
        /// </summary>
        /// <param name="SupplierFormMPositionActual">Updated entity of SupplierFormMPositionActual, <see cref="SupplierFormMPositionActual"/></param>
        /// <returns>Saved entity of SupplierFormMPositionActual, <see cref="SupplierFormMPositionActual"/></returns>
        public async Task UpdateAsync(SupplierFormMPositionActual supplierFormMPositionActual, string changeReason)
        {
            await UpdateAsync(supplierFormMPositionActual, Constants.AuditLog.Title.EditSupplierFormMPositionActual(supplierFormMPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMPositionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMPositionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMPositionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMPositionActual(role.LineNo), changeReason);

            Remove(role);
        }
    }
}

