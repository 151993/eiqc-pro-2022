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
    public class GoodsReceiveUserRepository : BaseRepository<GoodsReceiveUser, int>, IGoodsReceiveUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public GoodsReceiveUserRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new GoodsReceiveUser into database
        /// </summary>
        /// <param name="GoodsReceiveUser">New entity of GoodsReceiveUser, <see cref="GoodsReceiveUser"/></param>
        /// <returns>Saved entity of Role, <see cref="GoodsReceiveUser"/></returns>
        public async Task<GoodsReceiveUser> AddAsync(GoodsReceiveUser goodsReceiveUser, string changeReason)
        {
            return await AddAsync(goodsReceiveUser, Constants.AuditLog.Title.AddGoodsReceiveUser(goodsReceiveUser.WareHouse), changeReason);
        }

        /// <summary>
        /// Updates existing GoodsReceiveUser with new values
        /// </summary>
        /// <param name="GoodsReceiveUser">Updated entity of GoodsReceiveUser, <see cref="GoodsReceiveUser"/></param>
        /// <returns>Saved entity of GoodsReceiveUser, <see cref="GoodsReceiveUser"/></returns>
        public async Task UpdateAsync(GoodsReceiveUser goodsReceiveUser, string changeReason)
        {
            await UpdateAsync(goodsReceiveUser, Constants.AuditLog.Title.EditGoodsReceiveUser(goodsReceiveUser.WareHouse), changeReason);
        }

        /// <summary>
        /// Checks if the GoodsReceiveUser with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">GoodsReceiveUser Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed GoodsReceiveUser, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var goodsReceiveUser = await ValidateExistsAndGetAsync(id);

            SetAuditLog(goodsReceiveUser, Constants.AuditLog.Title.DeleteGoodsReceiveUser(goodsReceiveUser.WareHouse), changeReason);

            Remove(goodsReceiveUser);
        }
    }
}

