/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormLPositionActualRepository
    {
        Task<FormLPositionActual> AddAsync(FormLPositionActual formLPositionActual, string changeReason);

        Task UpdateAsync(FormLPositionActual formLPositionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
