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
    public class ReceiveGoodsInfoRepository : BaseRepository<ReceiveGoodsInfo, int>, IReceiveGoodsInfoRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ReceiveGoodsInfoRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new ReceiveGoodsInfo into database
        /// </summary>
        /// <param name="ReceiveGoodsInfo">New entity of ReceiveGoodsInfo, <see cref="ReceiveGoodsInfo"/></param>
        /// <returns>Saved entity of Role, <see cref="ReceiveGoodsInfo"/></returns>
        public async Task<ReceiveGoodsInfo> AddAsync(ReceiveGoodsInfo receiveGoodsInfo, string changeReason)
        {
            return await AddAsync(receiveGoodsInfo, Constants.AuditLog.Title.AddReceiveGoodsInfo(receiveGoodsInfo.Material), changeReason);
        }

        /// <summary>
        /// Updates existing ReceiveGoodsInfo with new values
        /// </summary>
        /// <param name="ReceiveGoodsInfo">Updated entity of ReceiveGoodsInfo, <see cref="ReceiveGoodsInfo"/></param>
        /// <returns>Saved entity of ReceiveGoodsInfo, <see cref="ReceiveGoodsInfo"/></returns>
        public async Task UpdateAsync(ReceiveGoodsInfo receiveGoodsInfo, string changeReason)
        {
            await UpdateAsync(receiveGoodsInfo, Constants.AuditLog.Title.EditReceiveGoodsInfo(receiveGoodsInfo.Material), changeReason);
        }

        /// <summary>
        /// Checks if the ReceiveGoodsInfo with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">ReceiveGoodsInfo Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed ReceiveGoodsInfo, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteReceiveGoodsInfo(role.Material), changeReason);

            Remove(role);
        }
    }
}

