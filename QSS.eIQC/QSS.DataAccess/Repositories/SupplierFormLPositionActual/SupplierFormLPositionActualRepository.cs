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
    public class SupplierFormLPositionActualRepository : BaseRepository<SupplierFormLPositionActual, int>, ISupplierFormLPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormLPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormLPositionActual into database
        /// </summary>
        /// <param name="SupplierFormLPositionActual">New entity of SupplierFormLPositionActual, <see cref="SupplierFormLPositionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormLPositionActual"/></returns>
        public async Task<SupplierFormLPositionActual> AddAsync(SupplierFormLPositionActual supplierFormLPositionActual, string changeReason)
        {
            return await AddAsync(supplierFormLPositionActual, Constants.AuditLog.Title.AddSupplierFormLPositionActual(supplierFormLPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormLPositionActual with new values
        /// </summary>
        /// <param name="SupplierFormLPositionActual">Updated entity of SupplierFormLPositionActual, <see cref="SupplierFormLPositionActual"/></param>
        /// <returns>Saved entity of SupplierFormLPositionActual, <see cref="SupplierFormLPositionActual"/></returns>
        public async Task UpdateAsync(SupplierFormLPositionActual supplierFormLPositionActual, string changeReason)
        {
            await UpdateAsync(supplierFormLPositionActual, Constants.AuditLog.Title.EditSupplierFormLPositionActual(supplierFormLPositionActual.LineNo), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormLPositionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormLPositionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormLPositionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormLPositionActual(role.LineNo), changeReason);

            Remove(role);
        }
    }
}

