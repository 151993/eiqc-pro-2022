/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISAPPartInspectionPlanRepository
    {
        Task<SAPPartInspectionPlan> AddAsync(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason, bool isRedefine);

        Task<SAPPartInspectionPlan> UpdateAsync(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
