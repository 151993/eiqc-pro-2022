/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierMeasurementSubmissionRepository : BaseRepository<SupplierMeasurementSubmission, int>, ISupplierMeasurementSubmissionRepository
    {
        private readonly QSSContext _context;
        public const int Zero = 0;
        public const int One = 1;
        public const int PaddingPosition = 4;
        public const char PaddingPrefix = '0';
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierMeasurementSubmissionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Create new SupplierMeasurementSubmission into database
        /// </summary>
        /// <param name="SupplierMeasurementSubmission">New entity of SupplierMeasurementSubmission, <see cref="SupplierMeasurementSubmission"/></param>
        /// <returns>Saved entity of Role, <see cref="SupplierMeasurementSubmission"/></returns>
        public async Task<SupplierMeasurementSubmission> AddAsync(SupplierMeasurementSubmission supplierMeasurementSubmission, string changeReason)
        {
            supplierMeasurementSubmission = this.GenerateSMSNo(supplierMeasurementSubmission);
            return await AddAsync(supplierMeasurementSubmission, Constants.AuditLog.Title.AddSupplierMeasurementSubmission(supplierMeasurementSubmission.IP), changeReason);
        }

        /// <summary>
        /// Updates existing SupplierMeasurementSubmission with new values
        /// </summary>
        /// <param name="SupplierMeasurementSubmission">Updated entity of SupplierMeasurementSubmission, <see cref="SupplierMeasurementSubmission"/></param>
        /// <returns>Saved entity of SupplierMeasurementSubmission, <see cref="SupplierMeasurementSubmission"/></returns>
        public async Task UpdateAsync(SupplierMeasurementSubmission supplierMeasurementSubmission, string changeReason)
        {
            await UpdateAsync(supplierMeasurementSubmission, Constants.AuditLog.Title.EditSupplierMeasurementSubmission(supplierMeasurementSubmission.IP), changeReason);
        }

        /// <summary>
        /// Checks if the SupplierMeasurementSubmission with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SupplierMeasurementSubmission Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SupplierMeasurementSubmission, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var supplierMeasurementSubmission = await ValidateExistsAndGetAsync(id);

            SetAuditLog(supplierMeasurementSubmission, Constants.AuditLog.Title.DeleteSupplierMeasurementSubmission(supplierMeasurementSubmission.IP), changeReason);

            Remove(supplierMeasurementSubmission);
        }

        private SupplierMeasurementSubmission GenerateSMSNo(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {

            var maxSMSSerialNumber = _context.SupplierMeasurementSubmission.DefaultIfEmpty().Max(p => p.SMSSerialNumber == null ? Zero : p.SMSSerialNumber) + One;
            var formatSMSSerialNumber = Convert.ToString(maxSMSSerialNumber).PadLeft(PaddingPosition, PaddingPrefix);
            supplierMeasurementSubmission.SMSNo = string.Format("{0}-{1}", supplierMeasurementSubmission.SMSNo, formatSMSSerialNumber);
            supplierMeasurementSubmission.SMSSerialNumber = maxSMSSerialNumber;
            return supplierMeasurementSubmission;
        }
    }
}

