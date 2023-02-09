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
    public class SupplierFormResultOrientedParameterRepository : BaseRepository<SupplierFormResultOrientedParameter, int>, ISupplierFormResultOrientedParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormResultOrientedParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormResultOrientedParameter into database
        /// </summary>
        /// <param name="SupplierFormResultOrientedParameter">New entity of SupplierFormResultOrientedParameter, <see cref="SupplierFormResultOrientedParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormResultOrientedParameter"/></returns>
        public async Task<SupplierFormResultOrientedParameter> AddAsync(SupplierFormResultOrientedParameter supplierFormResultOrientedParameter, string changeReason)
        {
            return await AddAsync(supplierFormResultOrientedParameter, Constants.AuditLog.Title.AddSupplierFormResultOrientedParameter(supplierFormResultOrientedParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormResultOrientedParameter with new values
        /// </summary>
        /// <param name="SupplierFormResultOrientedParameter">Updated entity of SupplierFormResultOrientedParameter, <see cref="SupplierFormResultOrientedParameter"/></param>
        /// <returns>Saved entity of SupplierFormResultOrientedParameter, <see cref="SupplierFormResultOrientedParameter"/></returns>
        public async Task UpdateAsync(SupplierFormResultOrientedParameter supplierFormResultOrientedParameter, string changeReason)
        {
            await UpdateAsync(supplierFormResultOrientedParameter, Constants.AuditLog.Title.EditSupplierFormResultOrientedParameter(supplierFormResultOrientedParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormResultOrientedParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormResultOrientedParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormResultOrientedParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormResultOrientedParameter(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

