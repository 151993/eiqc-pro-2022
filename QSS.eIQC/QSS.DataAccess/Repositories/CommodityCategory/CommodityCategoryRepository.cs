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
    public class CommodityCategoryRepository : BaseRepository<CommodityCategory, int>, ICommodityCategoryRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CommodityCategoryRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new CommodityCategory into database
        /// </summary>
        /// <param name="CommodityCategory">New entity of CommodityCategory, <see cref="CommodityCategory"/></param>
        /// <returns>Saved entity of Role, <see cref="CommodityCategory"/></returns>
        public async Task<CommodityCategory> AddAsync(CommodityCategory commodityCategory, string changeReason)
        {
            return await AddAsync(commodityCategory, Constants.AuditLog.Title.AddCommodityCategory(commodityCategory.Name), changeReason);
        }

        /// <summary>
        /// Updates existing CommodityCategory with new values
        /// </summary>
        /// <param name="CommodityCategory">Updated entity of CommodityCategory, <see cref="CommodityCategory"/></param>
        /// <returns>Saved entity of CommodityCategory, <see cref="CommodityCategory"/></returns>
        public async Task UpdateAsync(CommodityCategory commodityCategory, string changeReason)
        {
            await UpdateAsync(commodityCategory, Constants.AuditLog.Title.EditCommodityCategory(commodityCategory.Name), changeReason);
        }

        /// <summary>
        /// Checks if the CommodityCategory with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">CommodityCategory Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed CommodityCategory, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var commodityCategory = await ValidateExistsAndGetAsync(id);

            SetAuditLog(commodityCategory, Constants.AuditLog.Title.DeleteCommodityCategory(commodityCategory.Name), changeReason);

           return Remove(commodityCategory);
        }
    }
}

