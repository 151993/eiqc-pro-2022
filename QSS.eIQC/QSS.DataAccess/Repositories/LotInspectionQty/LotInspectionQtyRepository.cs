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
    public class LotInspectionQtyRepository : BaseRepository<LotInspectionQty, int>, ILotInspectionQtyRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public LotInspectionQtyRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new LotInspectionQty into database
        /// </summary>
        /// <param name="LotInspectionQty">New entity of LotInspectionQty, <see cref="LotInspectionQty"/></param>
        /// <returns>Saved entity of Role, <see cref="LotInspectionQty"/></returns>
        public async Task<LotInspectionQty> AddAsync(LotInspectionQty lotInspectionQty, string changeReason)
        {
            return await AddAsync(lotInspectionQty, Constants.AuditLog.Title.AddLotInspectionQty(lotInspectionQty.LotNo), changeReason);
        }

        /// <summary>
        /// Updates existing LotInspectionQty with new values
        /// </summary>
        /// <param name="LotInspectionQty">Updated entity of LotInspectionQty, <see cref="LotInspectionQty"/></param>
        /// <returns>Saved entity of LotInspectionQty, <see cref="LotInspectionQty"/></returns>
        public async Task UpdateAsync(LotInspectionQty lotInspectionQty, string changeReason)
        {
            await UpdateAsync(lotInspectionQty, Constants.AuditLog.Title.EditLotInspectionQty(lotInspectionQty.LotNo), changeReason);
        }

        /// <summary>
        /// Checks if the LotInspectionQty with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">LotInspectionQty Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed LotInspectionQty, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteLotInspectionQty(role.LotNo), changeReason);

            Remove(role);
        }
    }
}

