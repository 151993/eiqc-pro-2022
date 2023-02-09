/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormVISRepository
    {
        Task<FormVIS> AddAsync(FormVIS formVIS, string changeReason);

        Task UpdateAsync(FormVIS formVIS, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
