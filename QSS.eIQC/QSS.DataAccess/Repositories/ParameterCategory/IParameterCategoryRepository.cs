/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IParameterCategoryRepository
    {
        Task<ParameterCategory> AddAsync(ParameterCategory parameterCategory, string changeReason);

        Task UpdateAsync(ParameterCategory parameterCategory, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
