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
    public class SupplierFormCountParameterRepository : BaseRepository<SupplierFormCountParameter, int>, ISupplierFormCountParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormCountParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormCountParameter into database
        /// </summary>
        /// <param name="SupplierFormCountParameter">New entity of SupplierFormCountParameter, <see cref="SupplierFormCountParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormCountParameter"/></returns>
        public async Task<SupplierFormCountParameter> AddAsync(SupplierFormCountParameter supplierFormCountParameter, string changeReason)
        {
            return await AddAsync(supplierFormCountParameter, Constants.AuditLog.Title.AddSupplierFormCountParameter(supplierFormCountParameter.InspectionDetails), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormCountParameter with new values
        /// </summary>
        /// <param name="SupplierFormCountParameter">Updated entity of SupplierFormCountParameter, <see cref="SupplierFormCountParameter"/></param>
        /// <returns>Saved entity of SupplierFormCountParameter, <see cref="SupplierFormCountParameter"/></returns>
        public async Task UpdateAsync(SupplierFormCountParameter supplierFormCountParameter, string changeReason)
        {
            await UpdateAsync(supplierFormCountParameter, Constants.AuditLog.Title.EditSupplierFormCountParameter(supplierFormCountParameter.InspectionDetails), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormCountParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormCountParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormCountParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormCountParameter(role.InspectionDetails), changeReason);

            Remove(role);
        }
    }
}

