
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISupplierLPositionRepository
    {
        void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission);
    }
}