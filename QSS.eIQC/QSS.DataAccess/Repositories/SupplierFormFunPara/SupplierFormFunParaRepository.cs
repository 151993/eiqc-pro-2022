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
    public class SupplierFormFunParaRepository : BaseRepository<SupplierFormFunPara, int>, ISupplierFormFunParaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormFunParaRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormFunPara into database
        /// </summary>
        /// <param name="SupplierFormFunPara">New entity of SupplierFormFunPara, <see cref="SupplierFormFunPara"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormFunPara"/></returns>
        public async Task<SupplierFormFunPara> AddAsync(SupplierFormFunPara supplierFormFunPara, string changeReason)
        {
            return await AddAsync(supplierFormFunPara, Constants.AuditLog.Title.AddSupplierFormFunPara(supplierFormFunPara.ITCode), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormFunPara with new values
        /// </summary>
        /// <param name="SupplierFormFunPara">Updated entity of SupplierFormFunPara, <see cref="SupplierFormFunPara"/></param>
        /// <returns>Saved entity of SupplierFormFunPara, <see cref="SupplierFormFunPara"/></returns>
        public async Task UpdateAsync(SupplierFormFunPara supplierFormFunPara, string changeReason)
        {
            await UpdateAsync(supplierFormFunPara, Constants.AuditLog.Title.EditSupplierFormFunPara(supplierFormFunPara.ITCode), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormFunPara with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormFunPara Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormFunPara, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormFunPara(role.ITCode), changeReason);

            Remove(role);
        }
    }
}

