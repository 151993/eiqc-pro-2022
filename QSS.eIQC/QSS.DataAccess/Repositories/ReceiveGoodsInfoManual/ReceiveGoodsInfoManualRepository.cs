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
    public class ReceiveGoodsInfoManualRepository : BaseRepository<ReceiveGoodsInfoManual, int>, IReceiveGoodsInfoManualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ReceiveGoodsInfoManualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ReceiveGoodsInfoManual into database
        /// </summary>
        /// <param name="ReceiveGoodsInfoManual">New entity of ReceiveGoodsInfoManual, <see cref="ReceiveGoodsInfoManual"/></param>
        /// <returns>Saved entity of Role, <see cref="ReceiveGoodsInfoManual"/></returns>
        public async Task<ReceiveGoodsInfoManual> AddAsync(ReceiveGoodsInfoManual receiveGoodsInfoManual, string changeReason)
        {
            return await AddAsync(receiveGoodsInfoManual, Constants.AuditLog.Title.AddReceiveGoodsInfoManual(receiveGoodsInfoManual.Material), changeReason);
        }

        /// <summary>
        /// Updates existing ReceiveGoodsInfoManual with new values
        /// </summary>
        /// <param name="ReceiveGoodsInfoManual">Updated entity of ReceiveGoodsInfoManual, <see cref="ReceiveGoodsInfoManual"/></param>
        /// <returns>Saved entity of ReceiveGoodsInfoManual, <see cref="ReceiveGoodsInfoManual"/></returns>
        public async Task UpdateAsync(ReceiveGoodsInfoManual receiveGoodsInfoManual, string changeReason)
        {
            await UpdateAsync(receiveGoodsInfoManual, Constants.AuditLog.Title.EditReceiveGoodsInfoManual(receiveGoodsInfoManual.Material), changeReason);
        }

        /// <summary>
        /// Checks if the ReceiveGoodsInfoManual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ReceiveGoodsInfoManual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ReceiveGoodsInfoManual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteReceiveGoodsInfoManual(role.Material), changeReason);

            Remove(role);
        }
    }
}

