/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPCCodeInspectionToolsTypeRepository
    {
        Task<PCCodeInspectionToolsType> AddAsync(PCCodeInspectionToolsType pCCodeInspectionToolsType, string changeReason);

        Task UpdateAsync(PCCodeInspectionToolsType pCCodeInspectionToolsType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
