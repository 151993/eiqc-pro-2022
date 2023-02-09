/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IDCCConfigurationRepository
    {
        Task<DCCConfiguration> AddAsync(DCCConfiguration dCCConfiguration, string changeReason);

        Task<DCCConfiguration> UpdateAsync(DCCConfiguration dCCConfiguration, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
