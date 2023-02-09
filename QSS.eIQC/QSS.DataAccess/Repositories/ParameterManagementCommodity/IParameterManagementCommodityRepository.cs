using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for ParameterManagementCommodity 
    /// </summary>
    public interface IParameterManagementCommodityRepository
    {
        void AddParameterCommodityNames(ParameterManagement parameterManagement, List<int> commodityNameIds);
        void RemoveParameterCommodityNames(int parameterManagementId, List<int> commodityNameIds);
    }
}
