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
    public class SupplierFormSAPParameterRepository : BaseRepository<SupplierFormSAPParameter, int>, ISupplierFormSAPParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormSAPParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormSAPParameter into database
        /// </summary>
        /// <param name="SupplierFormSAPParameter">New entity of SupplierFormSAPParameter, <see cref="SupplierFormSAPParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormSAPParameter"/></returns>
        public async Task<SupplierFormSAPParameter> AddAsync(SupplierFormSAPParameter supplierFormSAPParameter, string changeReason)
        {
            return await AddAsync(supplierFormSAPParameter, Constants.AuditLog.Title.AddSupplierFormSAPParameter(supplierFormSAPParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormSAPParameter with new values
        /// </summary>
        /// <param name="SupplierFormSAPParameter">Updated entity of SupplierFormSAPParameter, <see cref="SupplierFormSAPParameter"/></param>
        /// <returns>Saved entity of SupplierFormSAPParameter, <see cref="SupplierFormSAPParameter"/></returns>
        public async Task UpdateAsync(SupplierFormSAPParameter supplierFormSAPParameter, string changeReason)
        {
            await UpdateAsync(supplierFormSAPParameter, Constants.AuditLog.Title.EditSupplierFormSAPParameter(supplierFormSAPParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormSAPParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormSAPParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormSAPParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormSAPParameter(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

