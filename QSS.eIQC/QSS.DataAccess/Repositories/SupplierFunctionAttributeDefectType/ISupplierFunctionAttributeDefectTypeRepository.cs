using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierFunctionAttributeDefectTypeRepository
    {
        void AddSupplierFunctionAttributeDefectTypes(SupplierFunctionAttribute supplierFunctionAttribute, List<int> defectTypeIds);
        
        void RemoveRange(SupplierFunctionAttribute supplierFunctionAttribute);
    }
}
