/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IInspectionToolsTypeRepository
    {
        Task<InspectionToolsType> AddAsync(InspectionToolsType inspectionToolsType, string changeReason);

        Task UpdateAsync(InspectionToolsType inspectionToolsType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
