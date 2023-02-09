/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartDimensionRepository
    {
        Task<PartDimension> AddAsync(PartDimension partDimension, string changeReason);

        Task<PartDimension> UpdateAsync(PartDimension partDimension, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
