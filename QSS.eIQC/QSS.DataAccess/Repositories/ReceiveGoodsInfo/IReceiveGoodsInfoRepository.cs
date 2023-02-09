/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IReceiveGoodsInfoRepository
    {
        Task<ReceiveGoodsInfo> AddAsync(ReceiveGoodsInfo receiveGoodsInfo, string changeReason);

        Task UpdateAsync(ReceiveGoodsInfo receiveGoodsInfo, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
