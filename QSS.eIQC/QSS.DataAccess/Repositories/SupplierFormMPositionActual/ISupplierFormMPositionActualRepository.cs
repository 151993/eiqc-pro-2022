/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMPositionActualRepository
    {
        Task<SupplierFormMPositionActual> AddAsync(SupplierFormMPositionActual supplierFormMPositionActual, string changeReason);

        Task UpdateAsync(SupplierFormMPositionActual supplierFormMPositionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
