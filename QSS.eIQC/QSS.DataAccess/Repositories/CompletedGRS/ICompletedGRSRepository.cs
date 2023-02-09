/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICompletedGRSRepository
    {
        Task<CompletedGRS> AddAsync(CompletedGRS completedGRS, string changeReason);

        Task UpdateAsync(CompletedGRS completedGRS, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
