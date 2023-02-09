using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierLPositionActualRepository
    {
        void AddSupplierLPositionActuals(SupplierLPosition supplierLPosition, IEnumerable<SupplierLPositionActual> supplierLPositionActuals);

        void RemoveRange(SupplierLPosition supplierLPosition);
    }
}