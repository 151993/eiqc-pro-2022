/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMicroSectionRepository
    {
        Task<SupplierFormMicroSection> AddAsync(SupplierFormMicroSection supplierFormMicroSection, string changeReason);

        Task UpdateAsync(SupplierFormMicroSection supplierFormMicroSection, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
