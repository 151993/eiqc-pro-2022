/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICommodityCategoryRepository
    {
        Task<CommodityCategory> AddAsync(CommodityCategory commodityCategory, string changeReason);

        Task UpdateAsync(CommodityCategory commodityCategory, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
