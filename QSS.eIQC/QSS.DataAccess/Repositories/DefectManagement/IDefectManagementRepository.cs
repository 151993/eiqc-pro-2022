/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IDefectManagementRepository
    {
        Task<DefectManagement> AddAsync(DefectManagement certificateType, string changeReason);

        Task<DefectManagement> UpdateAsync(DefectManagement certificateType, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
