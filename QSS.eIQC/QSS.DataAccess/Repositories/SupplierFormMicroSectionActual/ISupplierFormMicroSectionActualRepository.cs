/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMicroSectionActualRepository
    {
        Task<SupplierFormMicroSectionActual> AddAsync(SupplierFormMicroSectionActual supplierFormMicroSectionActual, string changeReason);

        Task UpdateAsync(SupplierFormMicroSectionActual supplierFormMicroSectionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
