/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IPartInspectionSpecificationRepository
    {
        void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan);

        Task UpdateAsync(PartInspectionSpecification partInspectionSpecification, string changeReason);

        void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan);

    }
}
