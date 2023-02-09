/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMeasurementParameterRepository
    {
        Task<FormMeasurementParameter> AddAsync(FormMeasurementParameter formMeasurementParameter, string changeReason);

        Task UpdateAsync(FormMeasurementParameter formMeasurementParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
