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
    public class SupplierFormMicroSectionActualRepository : BaseRepository<SupplierFormMicroSectionActual, int>, ISupplierFormMicroSectionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMicroSectionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMicroSectionActual into database
        /// </summary>
        /// <param name="SupplierFormMicroSectionActual">New entity of SupplierFormMicroSectionActual, <see cref="SupplierFormMicroSectionActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMicroSectionActual"/></returns>
        public async Task<SupplierFormMicroSectionActual> AddAsync(SupplierFormMicroSectionActual supplierFormMicroSectionActual, string changeReason)
        {
            return await AddAsync(supplierFormMicroSectionActual, Constants.AuditLog.Title.AddSupplierFormMicroSectionActual(supplierFormMicroSectionActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMicroSectionActual with new values
        /// </summary>
        /// <param name="SupplierFormMicroSectionActual">Updated entity of SupplierFormMicroSectionActual, <see cref="SupplierFormMicroSectionActual"/></param>
        /// <returns>Saved entity of SupplierFormMicroSectionActual, <see cref="SupplierFormMicroSectionActual"/></returns>
        public async Task UpdateAsync(SupplierFormMicroSectionActual supplierFormMicroSectionActual, string changeReason)
        {
            await UpdateAsync(supplierFormMicroSectionActual, Constants.AuditLog.Title.EditSupplierFormMicroSectionActual(supplierFormMicroSectionActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMicroSectionActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMicroSectionActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMicroSectionActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMicroSectionActual(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

