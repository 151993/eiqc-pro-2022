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
    public class SupplierFormFunParaActualRepository : BaseRepository<SupplierFormFunParaActual, int>, ISupplierFormFunParaActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormFunParaActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormFunParaActual into database
        /// </summary>
        /// <param name="SupplierFormFunParaActual">New entity of SupplierFormFunParaActual, <see cref="SupplierFormFunParaActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormFunParaActual"/></returns>
        public async Task<SupplierFormFunParaActual> AddAsync(SupplierFormFunParaActual supplierFormFunParaActual, string changeReason)
        {
            return await AddAsync(supplierFormFunParaActual, Constants.AuditLog.Title.AddSupplierFormFunParaActual(supplierFormFunParaActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormFunParaActual with new values
        /// </summary>
        /// <param name="SupplierFormFunParaActual">Updated entity of SupplierFormFunParaActual, <see cref="SupplierFormFunParaActual"/></param>
        /// <returns>Saved entity of SupplierFormFunParaActual, <see cref="SupplierFormFunParaActual"/></returns>
        public async Task UpdateAsync(SupplierFormFunParaActual supplierFormFunParaActual, string changeReason)
        {
            await UpdateAsync(supplierFormFunParaActual, Constants.AuditLog.Title.EditSupplierFormFunParaActual(supplierFormFunParaActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormFunParaActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormFunParaActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormFunParaActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormFunParaActual(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

