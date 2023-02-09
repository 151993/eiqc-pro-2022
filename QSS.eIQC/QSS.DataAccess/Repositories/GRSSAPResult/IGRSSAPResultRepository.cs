/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IGRSSAPResultRepository
    {
        Task<GRSSAPResult> AddAsync(GRSSAPResult gRSSAPResult, string changeReason);

        Task UpdateAsync(GRSSAPResult gRSSAPResult, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
