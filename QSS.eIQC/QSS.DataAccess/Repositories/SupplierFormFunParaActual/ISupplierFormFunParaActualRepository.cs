/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormFunParaActualRepository
    {
        Task<SupplierFormFunParaActual> AddAsync(SupplierFormFunParaActual supplierFormFunParaActual, string changeReason);

        Task UpdateAsync(SupplierFormFunParaActual supplierFormFunParaActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
