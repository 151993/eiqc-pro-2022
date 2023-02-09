/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierFunctionAttributeRepository : BaseRepository<SupplierFunctionAttribute, int>, ISupplierFunctionAttributeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFunctionAttributeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierFunctionAttributes.Count > 0)
            {
                var supplierFunctionAttributeToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (supplierFunctionAttributeToRemove != null)
                {
                    this.RemoveRange(supplierFunctionAttributeToRemove);
                }
            }
        }
    }
}

