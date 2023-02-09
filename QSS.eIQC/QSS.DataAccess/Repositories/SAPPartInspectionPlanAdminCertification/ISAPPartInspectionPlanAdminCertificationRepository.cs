

using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  SAPPartInspectionPlan dcc User
    /// </summary>
    public interface ISAPPartInspectionPlanAdminCertificationRepository
    {
        Task<IEnumerable<SAPPartInspectionPlanAdminCertification>> AddSAPPartInspectionPlanAdminCertifications(SAPPartInspectionPlan sapPartInspectionPlan, List<int> AdminCertificateIds);
        Task<IEnumerable<SAPPartInspectionPlanAdminCertification>> RemoveSAPPartInspectionPlanAdminCertifications(int sapPartInspectionPlanId, List<int> AdminCertificateIds);
    }
}
