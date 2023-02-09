/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormRepository
    {
        Task<Form> AddAsync(Form form, string changeReason);

        Task UpdateAsync(Form form, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
