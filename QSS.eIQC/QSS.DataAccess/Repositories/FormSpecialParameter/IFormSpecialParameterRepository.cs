/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormSpecialParameterRepository
    {
        Task<FormSpecialParameter> AddAsync(FormSpecialParameter FormSpecialParameter, string changeReason);

        Task UpdateAsync(FormSpecialParameter FormSpecialParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
