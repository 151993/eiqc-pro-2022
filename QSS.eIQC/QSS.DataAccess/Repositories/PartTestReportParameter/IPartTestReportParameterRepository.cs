/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartTestReportParameterRepository
    {
        void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan);

        Task UpdateAsync(PartTestReportParameter partTestReportParameter, string changeReason);

        void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan);

    }
}
