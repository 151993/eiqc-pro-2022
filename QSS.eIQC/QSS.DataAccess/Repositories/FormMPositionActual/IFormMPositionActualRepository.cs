/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMPositionActualRepository
    {
        Task<FormMPositionActual> AddAsync(FormMPositionActual formMPositionActual, string changeReason);

        Task UpdateAsync(FormMPositionActual formMPositionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
