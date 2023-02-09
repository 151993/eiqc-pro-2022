/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormBowTwistActualRepository
    {
        Task<FormBowTwistActual> AddAsync(FormBowTwistActual formBowTwistActual, string changeReason);

        Task UpdateAsync(FormBowTwistActual formBowTwistActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
