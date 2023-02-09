using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for SupplierBowTwistDefectType, provides Add, Update and Delete operations
    /// </summary>
    public class SupplierBowTwistActualRepository : Repository<SupplierBowTwistActual, int>, ISupplierBowTwistActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierBowTwistActualRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierBowTwistActuals(SupplierBowTwist supplierBowTwist, IEnumerable<SupplierBowTwistActual> bowTwistActual)
        {
            supplierBowTwist.SupplierBowTwistActuals.Clear();
            if (bowTwistActual != null && bowTwistActual.Count() > 0)
            {
                AddRange(bowTwistActual.Select(r =>
                   new SupplierBowTwistActual()
                   {
                       SupplierBowTwist = supplierBowTwist,
                       ActualTextName = r.ActualTextName,
                       ActualTextValue = r.ActualTextValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierBowTwist SupplierBowTwist)
        {
            if (SupplierBowTwist.Id != 0 && SupplierBowTwist.SupplierBowTwistActuals.Count > 0)
            {
                var SupplierBowTwistToRemove = this.Find(m => m.SupplierBowTwistId == SupplierBowTwist.Id);
                if (SupplierBowTwistToRemove != null)
                {
                    this.RemoveRange(SupplierBowTwistToRemove);
                }
            }
            else if (SupplierBowTwist.Id != 0 && SupplierBowTwist.SupplierBowTwistActuals != null && SupplierBowTwist.SupplierBowTwistActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierBowTwistId == SupplierBowTwist.Id));
            }
        }
    }
}
