/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IWorkCellUserRepository
    {
        Task<WorkCellUser> AddAsync(WorkCellUser workCellUser, string changeReason);

        Task UpdateAsync(WorkCellUser workCellUser, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
