/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormPackagingRepository
    {
        Task<FormPackaging> AddAsync(FormPackaging formPackaging, string changeReason);

        Task UpdateAsync(FormPackaging formPackaging, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
