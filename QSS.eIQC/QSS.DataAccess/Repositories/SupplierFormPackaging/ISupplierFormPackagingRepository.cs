/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormPackagingRepository
    {
        Task<SupplierFormPackaging> AddAsync(SupplierFormPackaging supplierFormPackaging, string changeReason);

        Task UpdateAsync(SupplierFormPackaging supplierFormPackaging, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
