/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartDateCodeRepository
    {
        Task<PartDateCode> AddAsync(PartDateCode partDateCode, string changeReason);

        Task UpdateAsync(PartDateCode partDateCode, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        void RemoveRange(SAPPartInspectionPlan sapPartInspectionPlan);
    }
}
