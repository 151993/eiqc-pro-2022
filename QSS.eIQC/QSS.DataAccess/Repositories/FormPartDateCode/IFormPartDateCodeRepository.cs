/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormPartDateCodeRepository
    {
        Task<FormPartDateCode> AddAsync(FormPartDateCode formPartDateCode, string changeReason);

        Task UpdateAsync(FormPartDateCode formPartDateCode, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
