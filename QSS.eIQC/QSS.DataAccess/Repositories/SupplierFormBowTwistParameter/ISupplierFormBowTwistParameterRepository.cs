/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormBowTwistParameterRepository
    {
        Task<SupplierFormBowTwistParameter> AddAsync(SupplierFormBowTwistParameter supplierFormBowTwistParameter, string changeReason);

        Task UpdateAsync(SupplierFormBowTwistParameter supplierFormBowTwistParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
