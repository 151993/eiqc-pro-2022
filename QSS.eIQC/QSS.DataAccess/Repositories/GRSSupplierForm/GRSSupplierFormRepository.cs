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
    public class GRSSupplierFormRepository : BaseRepository<GRSSupplierForm, int>, IGRSSupplierFormRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public GRSSupplierFormRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new GRSSupplierForm into database
        /// </summary>
        /// <param name="GRSSupplierForm">New entity of GRSSupplierForm, <see cref="GRSSupplierForm"/></param>
        /// <returns>Saved entity of Role, <see cref="GRSSupplierForm"/></returns>
        public async Task<GRSSupplierForm> AddAsync(GRSSupplierForm gRSSupplierForm, string changeReason)
        {
            return await AddAsync(gRSSupplierForm, Constants.AuditLog.Title.AddGRSSupplierForm(gRSSupplierForm.GRSNo), changeReason);
        }

        /// <summary>
        /// Updates existing GRSSupplierForm with new values
        /// </summary>
        /// <param name="GRSSupplierForm">Updated entity of GRSSupplierForm, <see cref="GRSSupplierForm"/></param>
        /// <returns>Saved entity of GRSSupplierForm, <see cref="GRSSupplierForm"/></returns>
        public async Task UpdateAsync(GRSSupplierForm gRSSupplierForm, string changeReason)
        {
            await UpdateAsync(gRSSupplierForm, Constants.AuditLog.Title.EditGRSSupplierForm(gRSSupplierForm.GRSNo), changeReason);
        }

        /// <summary>
        /// Checks if the GRSSupplierForm with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">GRSSupplierForm Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed GRSSupplierForm, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var gRSSupplierForm = await ValidateExistsAndGetAsync(id);

            SetAuditLog(gRSSupplierForm, Constants.AuditLog.Title.DeleteGRSSupplierForm(gRSSupplierForm.GRSNo), changeReason);

            Remove(gRSSupplierForm);
        }
    }
}

