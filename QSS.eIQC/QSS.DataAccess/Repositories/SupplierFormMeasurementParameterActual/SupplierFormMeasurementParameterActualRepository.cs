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
    public class SupplierFormMeasurementParameterActualRepository : BaseRepository<SupplierFormMeasurementParameterActual, int>, ISupplierFormMeasurementParameterActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMeasurementParameterActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMeasurementParameterActual into database
        /// </summary>
        /// <param name="SupplierFormMeasurementParameterActual">New entity of SupplierFormMeasurementParameterActual, <see cref="SupplierFormMeasurementParameterActual"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMeasurementParameterActual"/></returns>
        public async Task<SupplierFormMeasurementParameterActual> AddAsync(SupplierFormMeasurementParameterActual supplierFormMeasurementParameterActual, string changeReason)
        {
            return await AddAsync(supplierFormMeasurementParameterActual, Constants.AuditLog.Title.AddSupplierFormMeasurementParameterActual(supplierFormMeasurementParameterActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMeasurementParameterActual with new values
        /// </summary>
        /// <param name="SupplierFormMeasurementParameterActual">Updated entity of SupplierFormMeasurementParameterActual, <see cref="SupplierFormMeasurementParameterActual"/></param>
        /// <returns>Saved entity of SupplierFormMeasurementParameterActual, <see cref="SupplierFormMeasurementParameterActual"/></returns>
        public async Task UpdateAsync(SupplierFormMeasurementParameterActual supplierFormMeasurementParameterActual, string changeReason)
        {
            await UpdateAsync(supplierFormMeasurementParameterActual, Constants.AuditLog.Title.EditSupplierFormMeasurementParameterActual(supplierFormMeasurementParameterActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMeasurementParameterActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMeasurementParameterActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMeasurementParameterActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMeasurementParameterActual(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

