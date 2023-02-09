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
    public class SupplierFormBowTwistParameterRepository : BaseRepository<SupplierFormBowTwistParameter, int>, ISupplierFormBowTwistParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormBowTwistParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormBowTwistParameter into database
        /// </summary>
        /// <param name="SupplierFormBowTwistParameter">New entity of SupplierFormBowTwistParameter, <see cref="SupplierFormBowTwistParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormBowTwistParameter"/></returns>
        public async Task<SupplierFormBowTwistParameter> AddAsync(SupplierFormBowTwistParameter supplierFormBowTwistParameter, string changeReason)
        {
            return await AddAsync(supplierFormBowTwistParameter, Constants.AuditLog.Title.AddSupplierFormBowTwistParameter(supplierFormBowTwistParameter.Spec), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormBowTwistParameter with new values
        /// </summary>
        /// <param name="SupplierFormBowTwistParameter">Updated entity of SupplierFormBowTwistParameter, <see cref="SupplierFormBowTwistParameter"/></param>
        /// <returns>Saved entity of SupplierFormBowTwistParameter, <see cref="SupplierFormBowTwistParameter"/></returns>
        public async Task UpdateAsync(SupplierFormBowTwistParameter supplierFormBowTwistParameter, string changeReason)
        {
            await UpdateAsync(supplierFormBowTwistParameter, Constants.AuditLog.Title.EditSupplierFormBowTwistParameter(supplierFormBowTwistParameter.Spec), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormBowTwistParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormBowTwistParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormBowTwistParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormBowTwistParameter(role.Spec), changeReason);

            Remove(role);
        }
    }
}

