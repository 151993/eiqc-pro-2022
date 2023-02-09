using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierFunctionVariableActualRepository
    {
        void AddSupplierFunctionVariableAcutals(SupplierFunctionVariable supplierFunctionVariable, IEnumerable<SupplierFunctionVariableActual> SupplierFunctionVariableActuals);

        void RemoveRange(SupplierFunctionVariable supplierFunctionVariable);
    }
}