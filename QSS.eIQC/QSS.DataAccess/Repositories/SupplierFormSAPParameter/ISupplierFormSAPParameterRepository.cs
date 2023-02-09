/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormSAPParameterRepository
    {
        Task<SupplierFormSAPParameter> AddAsync(SupplierFormSAPParameter supplierFormSAPParameter, string changeReason);

        Task UpdateAsync(SupplierFormSAPParameter supplierFormSAPParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
