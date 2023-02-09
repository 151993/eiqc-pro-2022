/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormResultOrientedParameterRepository
    {
        Task<FormResultOrientedParameter> AddAsync(FormResultOrientedParameter formResultOrientedParameter, string changeReason);

        Task UpdateAsync(FormResultOrientedParameter formResultOrientedParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
