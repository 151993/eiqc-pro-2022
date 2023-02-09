/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierFormMeasurementParameterActualRepository
    {
        Task<SupplierFormMeasurementParameterActual> AddAsync(SupplierFormMeasurementParameterActual supplierFormMeasurementParameterActual, string changeReason);

        Task UpdateAsync(SupplierFormMeasurementParameterActual supplierFormMeasurementParameterActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
