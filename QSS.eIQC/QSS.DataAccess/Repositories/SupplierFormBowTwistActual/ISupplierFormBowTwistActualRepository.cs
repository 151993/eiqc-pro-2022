/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormBowTwistActualRepository
    {
        Task<SupplierFormBowTwistActual> AddAsync(SupplierFormBowTwistActual supplierFormBowTwistActual, string changeReason);

        Task UpdateAsync(SupplierFormBowTwistActual supplierFormBowTwistActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
