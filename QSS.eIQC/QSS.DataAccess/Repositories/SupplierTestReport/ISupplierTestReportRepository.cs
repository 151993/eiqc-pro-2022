/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierTestReportRepository
    {
        Task<SupplierTestReport> AddAsync(SupplierTestReport SupplierTestReport, string changeReason);

        Task UpdateAsync(SupplierTestReport SupplierTestReport, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission);
    }
}
