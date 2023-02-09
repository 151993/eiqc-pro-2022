/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IBowTwistFormulaRepository
    {
        Task<BowTwistFormula> AddAsync(BowTwistFormula bowTwistFormula, string changeReason);

        Task<BowTwistFormula> UpdateAsync(BowTwistFormula bowTwistFormula, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
