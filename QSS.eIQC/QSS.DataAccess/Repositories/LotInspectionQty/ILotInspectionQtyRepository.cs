/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ILotInspectionQtyRepository
    {
        Task<LotInspectionQty> AddAsync(LotInspectionQty lotInspectionQty, string changeReason);

        Task UpdateAsync(LotInspectionQty lotInspectionQty, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
