/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormLPositionRepository
    {
        Task<FormLPosition> AddAsync(FormLPosition formLPosition, string changeReason);

        Task UpdateAsync(FormLPosition formLPosition, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
