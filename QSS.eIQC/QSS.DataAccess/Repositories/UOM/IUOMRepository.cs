/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IUOMRepository
    {
        Task<UOM> AddAsync(UOM uOM, string changeReason);

        Task UpdateAsync(UOM uOM, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
