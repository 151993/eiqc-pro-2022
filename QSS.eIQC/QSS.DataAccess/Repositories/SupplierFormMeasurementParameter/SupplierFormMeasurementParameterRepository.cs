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
    public class SupplierFormMeasurementParameterRepository : BaseRepository<SupplierFormMeasurementParameter, int>, ISupplierFormMeasurementParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMeasurementParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMeasurementParameter into database
        /// </summary>
        /// <param name="SupplierFormMeasurementParameter">New entity of SupplierFormMeasurementParameter, <see cref="SupplierFormMeasurementParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMeasurementParameter"/></returns>
        public async Task<SupplierFormMeasurementParameter> AddAsync(SupplierFormMeasurementParameter supplierFormMeasurementParameter, string changeReason)
        {
            return await AddAsync(supplierFormMeasurementParameter, Constants.AuditLog.Title.AddSupplierFormMeasurementParameter(supplierFormMeasurementParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMeasurementParameter with new values
        /// </summary>
        /// <param name="SupplierFormMeasurementParameter">Updated entity of SupplierFormMeasurementParameter, <see cref="SupplierFormMeasurementParameter"/></param>
        /// <returns>Saved entity of SupplierFormMeasurementParameter, <see cref="SupplierFormMeasurementParameter"/></returns>
        public async Task UpdateAsync(SupplierFormMeasurementParameter supplierFormMeasurementParameter, string changeReason)
        {
            await UpdateAsync(supplierFormMeasurementParameter, Constants.AuditLog.Title.EditSupplierFormMeasurementParameter(supplierFormMeasurementParameter.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMeasurementParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMeasurementParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMeasurementParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMeasurementParameter(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

