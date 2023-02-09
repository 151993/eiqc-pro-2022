/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierMeasurementSubmissionRepository
    {
        Task<SupplierMeasurementSubmission> AddAsync(SupplierMeasurementSubmission supplierMeasurementSubmission, string changeReason);

        Task UpdateAsync(SupplierMeasurementSubmission supplierMeasurementSubmission, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
