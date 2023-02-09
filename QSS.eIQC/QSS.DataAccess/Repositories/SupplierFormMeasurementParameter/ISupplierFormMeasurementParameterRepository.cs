/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMeasurementParameterRepository
    {
        Task<SupplierFormMeasurementParameter> AddAsync(SupplierFormMeasurementParameter supplierFormMeasurementParameter, string changeReason);

        Task UpdateAsync(SupplierFormMeasurementParameter supplierFormMeasurementParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
