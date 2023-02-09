/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormResultOrientedParameterRepository
    {
        Task<SupplierFormResultOrientedParameter> AddAsync(SupplierFormResultOrientedParameter supplierFormResultOrientedParameter, string changeReason);

        Task UpdateAsync(SupplierFormResultOrientedParameter supplierFormResultOrientedParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
