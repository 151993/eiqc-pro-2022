/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMPositionRepository
    {
        Task<SupplierFormMPosition> AddAsync(SupplierFormMPosition supplierFormMPosition, string changeReason);

        Task UpdateAsync(SupplierFormMPosition supplierFormMPosition, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
