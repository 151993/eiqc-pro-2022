/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormBowTwistParameterRepository
    {
        Task<FormBowTwistParameter> AddAsync(FormBowTwistParameter formBowTwistParameter, string changeReason);

        Task UpdateAsync(FormBowTwistParameter formBowTwistParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
