/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormLPositionActualRepository
    {
        Task<SupplierFormLPositionActual> AddAsync(SupplierFormLPositionActual supplierFormLPositionActual, string changeReason);

        Task UpdateAsync(SupplierFormLPositionActual supplierFormLPositionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
