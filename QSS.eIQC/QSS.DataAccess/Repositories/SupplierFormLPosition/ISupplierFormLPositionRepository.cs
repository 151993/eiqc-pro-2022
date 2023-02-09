/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormLPositionRepository
    {
        Task<SupplierFormLPosition> AddAsync(SupplierFormLPosition supplierFormLPosition, string changeReason);

        Task UpdateAsync(SupplierFormLPosition supplierFormLPosition, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
