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
    public class FormPartSAPFailedQtyRepository : BaseRepository<FormPartSAPFailedQty, int>, IFormPartSAPFailedQtyRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormPartSAPFailedQtyRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormPartSAPFailedQty into database
        /// </summary>
        /// <param name="FormPartSAPFailedQty">New entity of FormPartSAPFailedQty, <see cref="FormPartSAPFailedQty"/></param>
        /// <returns>Saved entity of Role, <see cref="FormPartSAPFailedQty"/></returns>
        public async Task<FormPartSAPFailedQty> AddAsync(FormPartSAPFailedQty formPartSAPFailedQty, string changeReason)
        {
            return await AddAsync(formPartSAPFailedQty, Constants.AuditLog.Title.AddFormPartSAPFailedQty(formPartSAPFailedQty.PCCode), changeReason);
        }

        /// <summary>
        /// Updates existing FormPartSAPFailedQty with new values
        /// </summary>
        /// <param name="FormPartSAPFailedQty">Updated entity of FormPartSAPFailedQty, <see cref="FormPartSAPFailedQty"/></param>
        /// <returns>Saved entity of FormPartSAPFailedQty, <see cref="FormPartSAPFailedQty"/></returns>
        public async Task UpdateAsync(FormPartSAPFailedQty formPartSAPFailedQty, string changeReason)
        {
            await UpdateAsync(formPartSAPFailedQty, Constants.AuditLog.Title.EditFormPartSAPFailedQty(formPartSAPFailedQty.PCCode), changeReason);
        }

        /// <summary>
        /// Checks if the FormPartSAPFailedQty with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormPartSAPFailedQty Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormPartSAPFailedQty, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formPartSAPFailedQty = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formPartSAPFailedQty, Constants.AuditLog.Title.DeleteFormPartSAPFailedQty(formPartSAPFailedQty.PCCode), changeReason);

            Remove(formPartSAPFailedQty);
        }
    }
}

