/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormFunParaRepository
    {
        Task<SupplierFormFunPara> AddAsync(SupplierFormFunPara supplierFormFunPara, string changeReason);

        Task UpdateAsync(SupplierFormFunPara supplierFormFunPara, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
