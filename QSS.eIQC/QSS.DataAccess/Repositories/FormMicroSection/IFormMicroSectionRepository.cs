/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormMicroSectionRepository
    {
        Task<FormMicroSection> AddAsync(FormMicroSection formMicroSection, string changeReason);

        Task UpdateAsync(FormMicroSection formMicroSection, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
