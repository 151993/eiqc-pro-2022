/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartCAFRepository
    {
        Task<PartCAF> AddAsync(PartCAF partCAF, string changeReason);

        Task UpdateAsync(PartCAF partCAF, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
