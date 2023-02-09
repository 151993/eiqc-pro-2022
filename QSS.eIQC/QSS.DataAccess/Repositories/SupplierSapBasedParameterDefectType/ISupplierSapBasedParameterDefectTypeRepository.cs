using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierSapBasedParameterDefectTypeRepository
    {
        void AddSupplierSapBasedParameterDefectTypes(SupplierSapBasedParameter supplierSapBasedParameter, List<int> defectTypeIds);
        
        void RemoveRange(SupplierSapBasedParameter supplierSapBasedParameter);
    }
}
