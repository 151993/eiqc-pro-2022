/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormCountParameterRepository
    {
        Task<FormCountParameter> AddAsync(FormCountParameter formCountParameter, string changeReason);

        Task UpdateAsync(FormCountParameter formCountParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
