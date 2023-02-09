/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormPartDateCodeRepository
    {
        Task<SupplierFormPartDateCode> AddAsync(SupplierFormPartDateCode supplierFormPartDateCode, string changeReason);

        Task UpdateAsync(SupplierFormPartDateCode supplierFormPartDateCode, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
