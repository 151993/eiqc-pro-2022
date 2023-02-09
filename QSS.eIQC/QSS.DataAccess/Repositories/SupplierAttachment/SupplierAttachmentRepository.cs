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
    public class SupplierAttachmentRepository : BaseRepository<SupplierAttachment, int>, ISupplierAttachmentRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierAttachmentRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new SupplierAttachment into database
        /// </summary>
        /// <param name="SupplierAttachment">New entity of SupplierAttachment, <see cref="SupplierAttachment"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierAttachment"/></returns>
        public async Task<SupplierAttachment> AddAsync(SupplierAttachment supplierAttachment, string changeReason)
        {
            return await AddAsync(supplierAttachment, Constants.AuditLog.Title.AddSupplierAttachment(supplierAttachment.Path), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierAttachment with new values
        /// </summary>
        /// <param name="SupplierAttachment">Updated entity of SupplierAttachment, <see cref="SupplierAttachment"/></param>
        /// <returns>Saved entity of SupplierAttachment, <see cref="SupplierAttachment"/></returns>
        public async Task UpdateAsync(SupplierAttachment supplierAttachment, string changeReason)
        {
            await UpdateAsync(supplierAttachment, Constants.AuditLog.Title.EditSupplierAttachment(supplierAttachment.Path), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierAttachment with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierAttachment Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierAttachment, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var supplierAttachment = await ValidateExistsAndGetAsync(id);

            SetAuditLog(supplierAttachment, Constants.AuditLog.Title.DeleteSupplierAttachment(supplierAttachment.Path), changeReason);

            Remove(supplierAttachment);
        }
    }
}

