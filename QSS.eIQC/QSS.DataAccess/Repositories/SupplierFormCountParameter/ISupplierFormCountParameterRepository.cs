/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormCountParameterRepository
    {
        Task<SupplierFormCountParameter> AddAsync(SupplierFormCountParameter supplierFormCountParameter, string changeReason);

        Task UpdateAsync(SupplierFormCountParameter supplierFormCountParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
