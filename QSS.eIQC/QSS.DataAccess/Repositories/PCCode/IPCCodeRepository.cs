/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPCCodeRepository
    {
        Task<PCCode> AddAsync(PCCode pCCode, string changeReason);

        Task UpdateAsync(PCCode pCCode, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
