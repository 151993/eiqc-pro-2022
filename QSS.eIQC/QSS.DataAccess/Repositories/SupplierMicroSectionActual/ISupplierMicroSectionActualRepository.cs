using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierMicroSectionActualRepository
    {
        void AddSupplierMicroSectionActuals(SupplierMicrosection supplierMicroSection, IEnumerable<SupplierMicroSectionActual> MicroSectionActuals);
        
        void RemoveRange(SupplierMicrosection supplierMicroSection);
    }
}
