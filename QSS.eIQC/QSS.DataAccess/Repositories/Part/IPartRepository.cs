/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartRepository
    {
        Task<Part> AddAsync(Part part, string changeReason);

        Task UpdateAsync(Part part, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        Task<string> GetCAFNoPrefix(int siteId, int workCellId);
    }
}
