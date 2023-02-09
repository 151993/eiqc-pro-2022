/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IGRSRepository
    {
        Task<GRS> AddAsync(GRS gRS, string changeReason);

        Task UpdateAsync(GRS gRS, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
