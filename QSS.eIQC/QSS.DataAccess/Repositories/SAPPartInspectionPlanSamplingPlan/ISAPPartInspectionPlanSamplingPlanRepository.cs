using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  SAPPartInspectionPlan User
    /// </summary>
    public interface ISAPPartInspectionPlanSamplingPlanRepository
    {
        Task<SAPPartInspectionPlan> AddSAPPartInspectionPlanSamplingPlans(SAPPartInspectionPlan sapPartInspectionPlan);
        Task<IEnumerable<SAPPartInspectionPlanSamplingPlan>> RemoveSAPPartInspectionPlanSamplingPlans(int sapPartInspectionPlanId, List<int> SAPPartInspectionPlanIds);
    }
}
