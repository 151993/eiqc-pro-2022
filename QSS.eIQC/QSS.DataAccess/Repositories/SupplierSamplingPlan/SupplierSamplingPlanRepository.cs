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
    public class SupplierSamplingPlanRepository : BaseRepository<SupplierSamplingPlan, int>, ISupplierSamplingPlanRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierSamplingPlanRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierSamplingPlan into database
        /// </summary>
        /// <param name="SupplierSamplingPlan">New entity of SupplierSamplingPlan, <see cref="SupplierSamplingPlan"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierSamplingPlan"/></returns>
        public async Task<SupplierSamplingPlan> AddAsync(SupplierSamplingPlan supplierSamplingPlan, string changeReason)
        {
            return await AddAsync(supplierSamplingPlan, Constants.AuditLog.Title.AddSupplierSamplingPlan(supplierSamplingPlan.Id), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierSamplingPlan with new values
        /// </summary>
        /// <param name="SupplierSamplingPlan">Updated entity of SupplierSamplingPlan, <see cref="SupplierSamplingPlan"/></param>
        /// <returns>Saved entity of SupplierSamplingPlan, <see cref="SupplierSamplingPlan"/></returns>
        public async Task UpdateAsync(SupplierSamplingPlan supplierSamplingPlan, string changeReason)
        {
            await UpdateAsync(supplierSamplingPlan, Constants.AuditLog.Title.EditSupplierSamplingPlan(supplierSamplingPlan.Id), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierSamplingPlan with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierSamplingPlan Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierSamplingPlan, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var supplierSamplingPlan = await ValidateExistsAndGetAsync(id);

            SetAuditLog(supplierSamplingPlan, Constants.AuditLog.Title.DeleteSupplierSamplingPlan(supplierSamplingPlan.Id), changeReason);

            Remove(supplierSamplingPlan);
        }
    }
}

