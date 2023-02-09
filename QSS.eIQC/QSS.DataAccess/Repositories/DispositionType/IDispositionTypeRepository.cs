/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IDispositionTypeRepository
    {
        Task<DispositionType> AddAsync(DispositionType dispositionType, string changeReason);

        Task UpdateAsync(DispositionType dispositionType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
