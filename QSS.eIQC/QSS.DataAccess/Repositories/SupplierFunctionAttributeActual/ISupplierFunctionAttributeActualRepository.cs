using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierFunctionAttributeActualRepository
    {
        void AddSupplierFunctionAttributeActuals(SupplierFunctionAttribute supplierFunctionAttribute, IEnumerable<SupplierFunctionAttributeActual> FunctionAttributeActuals);
        
        void RemoveRange(SupplierFunctionAttribute supplierFunctionAttribute);
    }
}
