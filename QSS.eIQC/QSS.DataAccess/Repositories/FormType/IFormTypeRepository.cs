/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormTypeRepository
    {
        Task<FormType> AddAsync(FormType formType, string changeReason);

        Task UpdateAsync(FormType formType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
