/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IGoodsReceiveUserRepository
    {
        Task<GoodsReceiveUser> AddAsync(GoodsReceiveUser goodsReceiveUser, string changeReason);

        Task UpdateAsync(GoodsReceiveUser goodsReceiveUser, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
