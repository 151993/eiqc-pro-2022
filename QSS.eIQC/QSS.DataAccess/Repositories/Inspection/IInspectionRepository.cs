/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IInspectionRepository
    {
        Task<Inspection> AddAsync(Inspection inspection, string changeReason);

        Task UpdateAsync(Inspection inspection, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
