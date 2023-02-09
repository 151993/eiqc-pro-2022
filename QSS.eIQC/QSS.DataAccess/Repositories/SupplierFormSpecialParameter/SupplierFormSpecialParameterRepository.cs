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
    public class SupplierFormSpecialParameterRepository : BaseRepository<SupplierFormSpecialParameter, int>, ISupplierFormSpecialParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormSpecialParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormSpecialParameter into database
        /// </summary>
        /// <param name="SupplierFormSpecialParameter">New entity of SupplierFormSpecialParameter, <see cref="SupplierFormSpecialParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormSpecialParameter"/></returns>
        public async Task<SupplierFormSpecialParameter> AddAsync(SupplierFormSpecialParameter supplierFormSpecialParameter, string changeReason)
        {
            return await AddAsync(supplierFormSpecialParameter, Constants.AuditLog.Title.AddSupplierFormSpecialParameter(supplierFormSpecialParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormSpecialParameter with new values
        /// </summary>
        /// <param name="SupplierFormSpecialParameter">Updated entity of SupplierFormSpecialParameter, <see cref="SupplierFormSpecialParameter"/></param>
        /// <returns>Saved entity of SupplierFormSpecialParameter, <see cref="SupplierFormSpecialParameter"/></returns>
        public async Task UpdateAsync(SupplierFormSpecialParameter supplierFormSpecialParameter, string changeReason)
        {
            await UpdateAsync(supplierFormSpecialParameter, Constants.AuditLog.Title.EditSupplierFormSpecialParameter(supplierFormSpecialParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormSpecialParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormSpecialParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormSpecialParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormSpecialParameter(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

