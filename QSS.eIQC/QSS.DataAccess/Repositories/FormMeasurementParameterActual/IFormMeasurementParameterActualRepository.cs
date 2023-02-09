/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMeasurementParameterActualRepository
    {
        Task<FormMeasurementParameterActual> AddAsync(FormMeasurementParameterActual formMeasurementParameterActual, string changeReason);

        Task UpdateAsync(FormMeasurementParameterActual formMeasurementParameterActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
