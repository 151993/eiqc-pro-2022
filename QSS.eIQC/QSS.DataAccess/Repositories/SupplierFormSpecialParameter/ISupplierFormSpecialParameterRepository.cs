/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormSpecialParameterRepository
    {
        Task<SupplierFormSpecialParameter> AddAsync(SupplierFormSpecialParameter supplierFormSpecialParameter, string changeReason);

        Task UpdateAsync(SupplierFormSpecialParameter supplierFormSpecialParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
