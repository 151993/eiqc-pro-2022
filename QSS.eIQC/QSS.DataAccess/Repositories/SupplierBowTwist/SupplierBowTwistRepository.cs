/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierBowTwistRepository : BaseRepository<SupplierBowTwist, int>, ISupplierBowTwistRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierBowTwistRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierBowTwists.Count > 0)
            {
                var supplierBowTwistToRemove = this.Find(m => m.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id);
                if (supplierBowTwistToRemove != null)
                {
                    this.RemoveRange(supplierBowTwistToRemove);
                }
            }
        }
    }
}

