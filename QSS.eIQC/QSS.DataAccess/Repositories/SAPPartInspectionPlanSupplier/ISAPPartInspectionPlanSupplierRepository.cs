using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  SAPPartInspectionPlan User
    /// </summary>
    public interface ISAPPartInspectionPlanSupplierRepository
    {
        Task<IEnumerable<SAPPartInspectionPlanSupplier>> AddSAPPartInspectionPlanSuppliers(SAPPartInspectionPlan sapPartInspectionPlan, List<int> SAPPartInspectionPlanIds);
        Task<IEnumerable<SAPPartInspectionPlanSupplier>> RemoveSAPPartInspectionPlanSuppliers(int sapPartInspectionPlanId, List<int> SAPPartInspectionPlanIds);
    }
}
