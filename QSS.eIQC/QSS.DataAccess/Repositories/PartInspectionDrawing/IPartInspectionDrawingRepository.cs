/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartInspectionDrawingRepository
    {
        void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan);

        Task UpdateAsync(PartInspectionDrawing partInspectionDrawing, string changeReason);

        void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan);

    }
}
