/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
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
    public class SupplierMPositionActualRepository : BaseRepository<SupplierMPositionActual, int>, ISupplierMPositionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierMPositionActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierMPositionActuals(SupplierMPosition supplierMPosition, IEnumerable<SupplierMPositionActual> supplierMPositionActual)
        {
            supplierMPosition.SupplierMPositionActuals.Clear();
            if (supplierMPositionActual != null && supplierMPositionActual.Count() > 0)
            {
                AddRange(supplierMPositionActual.Select(r =>
                   new SupplierMPositionActual()
                   {
                       SupplierMPosition = supplierMPosition,
                       ActualText = r.ActualText,
                       ActualValue = r.ActualValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierMPosition supplierMPosition)
        {
            if (supplierMPosition.Id != 0 && supplierMPosition.SupplierMPositionActuals.Count > 0)
            {
                var SupplierBowTwistToRemove = this.Find(m => m.SupplierMPositionId == supplierMPosition.Id);
                if (SupplierBowTwistToRemove != null)
                {
                    this.RemoveRange(SupplierBowTwistToRemove);
                }
            }
            else if (supplierMPosition.Id != 0 && supplierMPosition.SupplierMPositionActuals != null && supplierMPosition.SupplierMPositionActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierMPositionId == supplierMPosition.Id));
            }
        }
    }
}

