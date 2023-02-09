/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormFunParaActualRepository
    {
        Task<FormFunParaActual> AddAsync(FormFunParaActual formFunParaActual, string changeReason);

        Task UpdateAsync(FormFunParaActual formFunParaActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
