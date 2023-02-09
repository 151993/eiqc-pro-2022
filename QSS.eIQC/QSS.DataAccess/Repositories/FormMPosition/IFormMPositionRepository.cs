/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMPositionRepository
    {
        Task<FormMPosition> AddAsync(FormMPosition formMPosition, string changeReason);

        Task UpdateAsync(FormMPosition formMPosition, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
