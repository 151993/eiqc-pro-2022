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
    public class SupplierFormVISRepository : BaseRepository<SupplierFormVIS, int>, ISupplierFormVISRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormVISRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormVIS into database
        /// </summary>
        /// <param name="SupplierFormVIS">New entity of SupplierFormVIS, <see cref="SupplierFormVIS"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormVIS"/></returns>
        public async Task<SupplierFormVIS> AddAsync(SupplierFormVIS supplierFormVIS, string changeReason)
        {
            return await AddAsync(supplierFormVIS, Constants.AuditLog.Title.AddSupplierFormVIS("supplierFormVIS"), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormVIS with new values
        /// </summary>
        /// <param name="SupplierFormVIS">Updated entity of SupplierFormVIS, <see cref="SupplierFormVIS"/></param>
        /// <returns>Saved entity of SupplierFormVIS, <see cref="SupplierFormVIS"/></returns>
        public async Task UpdateAsync(SupplierFormVIS supplierFormVIS, string changeReason)
        {
            await UpdateAsync(supplierFormVIS, Constants.AuditLog.Title.EditSupplierFormVIS("supplierFormVIS"), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormVIS with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormVIS Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormVIS, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormVIS("supplierFormVIS"), changeReason);

            Remove(role);
        }
    }
}

