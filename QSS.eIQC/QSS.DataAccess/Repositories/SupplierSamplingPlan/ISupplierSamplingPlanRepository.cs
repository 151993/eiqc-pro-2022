/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierSamplingPlanRepository
    {
        Task<SupplierSamplingPlan> AddAsync(SupplierSamplingPlan supplierSamplingPlan, string changeReason);

        Task UpdateAsync(SupplierSamplingPlan supplierSamplingPlan, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
