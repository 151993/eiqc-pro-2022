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
    public class SupplierFormMicroSectionRepository : BaseRepository<SupplierFormMicroSection, int>, ISupplierFormMicroSectionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFormMicroSectionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierFormMicroSection into database
        /// </summary>
        /// <param name="SupplierFormMicroSection">New entity of SupplierFormMicroSection, <see cref="SupplierFormMicroSection"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierFormMicroSection"/></returns>
        public async Task<SupplierFormMicroSection> AddAsync(SupplierFormMicroSection supplierFormMicroSection, string changeReason)
        {
            return await AddAsync(supplierFormMicroSection, Constants.AuditLog.Title.AddSupplierFormMicroSection(supplierFormMicroSection.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierFormMicroSection with new values
        /// </summary>
        /// <param name="SupplierFormMicroSection">Updated entity of SupplierFormMicroSection, <see cref="SupplierFormMicroSection"/></param>
        /// <returns>Saved entity of SupplierFormMicroSection, <see cref="SupplierFormMicroSection"/></returns>
        public async Task UpdateAsync(SupplierFormMicroSection supplierFormMicroSection, string changeReason)
        {
            await UpdateAsync(supplierFormMicroSection, Constants.AuditLog.Title.EditSupplierFormMicroSection(supplierFormMicroSection.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierFormMicroSection with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierFormMicroSection Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierFormMicroSection, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteSupplierFormMicroSection(role.ParameterName), changeReason);

            Remove(role);
        }
    }
}

