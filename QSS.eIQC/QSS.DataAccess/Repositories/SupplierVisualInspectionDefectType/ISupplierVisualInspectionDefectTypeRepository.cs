using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierVisualInspectionDefectTypeRepository
    {
        void AddSupplierVisualInspectionDefectTypes(SupplierVisualInspection supplierVisualInspection, List<int> defectTypeIds);
        
        void RemoveRange(SupplierVisualInspection supplierVisualInspection);
    }
}
