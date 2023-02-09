/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IParameterTypeRepository
    {
        Task<ParameterType> AddAsync(ParameterType parameterType, string changeReason);

        Task UpdateAsync(ParameterType parameterType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
