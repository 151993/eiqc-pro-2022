/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISiteRepository
    {
        Task<Site> AddAsync(Site site, string changeReason);

        Task UpdateAsync(Site site, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
