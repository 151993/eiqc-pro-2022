/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMicroSectionActualRepository
    {
        Task<FormMicroSectionActual> AddAsync(FormMicroSectionActual formMicroSectionActual, string changeReason);

        Task UpdateAsync(FormMicroSectionActual formMicroSectionActual, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
