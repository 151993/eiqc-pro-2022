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
    public class SupplierLPositionActualRepository : BaseRepository<SupplierLPositionActual, int>, ISupplierLPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierLPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierLPositionActuals(SupplierLPosition supplierLPosition, IEnumerable<SupplierLPositionActual> supplierLPositionActual)
        {
            supplierLPosition.SupplierLPositionActuals.Clear();
            if (supplierLPositionActual != null && supplierLPositionActual.Count() > 0)
            {
                AddRange(supplierLPositionActual.Select(r =>
                   new SupplierLPositionActual()
                   {
                       SupplierLPosition = supplierLPosition,
                       ActualText = r.ActualText,
                       ActualValue = r.ActualValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierLPosition supplierLPosition)
        {
            if (supplierLPosition.Id != 0 && supplierLPosition.SupplierLPositionActuals.Count > 0)
            {
                var SupplierBowTwistToRemove = this.Find(m => m.SupplierLPositionId == supplierLPosition.Id);
                if (SupplierBowTwistToRemove != null)
                {
                    this.RemoveRange(SupplierBowTwistToRemove);
                }
            }
            else if (supplierLPosition.Id != 0 && supplierLPosition.SupplierLPositionActuals != null && supplierLPosition.SupplierLPositionActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierLPositionId == supplierLPosition.Id));
            }
        }
    }
}

