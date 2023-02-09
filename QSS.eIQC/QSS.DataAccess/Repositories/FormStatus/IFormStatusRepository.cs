/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormStatusRepository
    {
        Task<FormStatus> AddAsync(FormStatus FormStatus, string changeReason);

        Task UpdateAsync(FormStatus FormStatus, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
