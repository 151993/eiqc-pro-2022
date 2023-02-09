/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SupplierLPositionRepository : BaseRepository<SupplierLPosition, int>, ISupplierLPositionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierLPositionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {

        }
        public void RemoveRange(SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (supplierMeasurementSubmission.Id != 0 && supplierMeasurementSubmission.SupplierLPositions.Count > 0)
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

