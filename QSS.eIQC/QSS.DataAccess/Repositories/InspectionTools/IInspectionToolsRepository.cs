/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IInspectionToolsRepository
    {
        Task<InspectionTools> AddAsync(InspectionTools inspectionTools, string changeReason);

        Task UpdateAsync(InspectionTools inspectionTools, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
