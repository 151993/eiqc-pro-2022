/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormVISRepository
    {
        Task<SupplierFormVIS> AddAsync(SupplierFormVIS supplierFormVIS, string changeReason);

        Task UpdateAsync(SupplierFormVIS supplierFormVIS, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
