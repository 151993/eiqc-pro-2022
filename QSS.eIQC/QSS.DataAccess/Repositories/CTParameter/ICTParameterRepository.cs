/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICTParameterRepository
    {
        Task<CTParameter> AddAsync(CTParameter cTParameter, string changeReason);

        Task UpdateAsync(CTParameter cTParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
