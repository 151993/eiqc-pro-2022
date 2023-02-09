/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartInspectionBowTwistParameterRepository
    {
        Task<PartInspectionBowTwistParameter> AddAsync(PartInspectionBowTwistParameter partInspectionBowTwistParameter, string changeReason);

        Task UpdateAsync(PartInspectionBowTwistParameter partInspectionBowTwistParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan);
    }
}
