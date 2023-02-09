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
    public class SupplierFormBowTwistActualRepository : BaseRepository<SupplierFormBowTwistActual, int>, ISupplierFormBowTwistActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormBowTwistActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormBowTwistActual into database
        /// </summary>
        /// <param name="SupplierFormBowTwistActual">New entity of SupplierFormBowTwistActual, <see cref="SupplierFormBowTwistActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormBowTwistActual"/></returns>
        public async Task<SupplierFormBowTwistActual> AddAsync(SupplierFormBowTwistActual supplierFormBowTwistActual, string changeReason)
        {
            return await AddAsync(supplierFormBowTwistActual, Constants.AuditLog.Title.AddSupplierFormBowTwistActual("supplierFormBowTwistActual"), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormBowTwistActual with new values
        /// </summary>
        /// <param name="SupplierFormBowTwistActual">Updated entity of SupplierFormBowTwistActual, <see cref="SupplierFormBowTwistActual"/></param>
        /// <returns>Saved entity of SupplierFormBowTwistActual, <see cref="SupplierFormBowTwistActual"/></returns>
        public async Task UpdateAsync(SupplierFormBowTwistActual supplierFormBowTwistActual, string changeReason)
        {
            await UpdateAsync(supplierFormBowTwistActual, Constants.AuditLog.Title.EditSupplierFormBowTwistActual("supplierFormBowTwistActual"), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormBowTwistActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormBowTwistActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormBowTwistActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormBowTwistActual("supplierFormBowTwistActual"), changeReason);

            Remove(role);
        }
    }
}

