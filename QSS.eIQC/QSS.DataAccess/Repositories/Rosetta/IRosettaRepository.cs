/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IRosettaRepository
    {
        Task<Rosetta> AddAsync(Rosetta rosetta, string changeReason);

        Task UpdateAsync(Rosetta rosetta, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
