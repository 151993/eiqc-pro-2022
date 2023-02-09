/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormRepository
    {
        Task<SupplierForm> AddAsync(SupplierForm supplierForm, string changeReason);

        Task UpdateAsync(SupplierForm supplierForm, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
