using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for SupplierFunctionAttributeDefectType, provides Add, Update and Delete operations
    /// </summary>
    public class SupplierVisualInspectionDefectTypeRepository : Repository<SupplierVisualInspectionDefectType, int>, ISupplierVisualInspectionDefectTypeRepository
    { 
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierVisualInspectionDefectTypeRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierVisualInspectionDefectTypes(SupplierVisualInspection supplierVisualInspection, List<int> defectTypeIds)
        {
            if (defectTypeIds != null && defectTypeIds.IsAny())
            {
                AddRange(defectTypeIds.Select(r =>
                   new SupplierVisualInspectionDefectType()
                   {
                       SupplierVisualInspection = supplierVisualInspection,
                       DefectTypeId = r
                   }
                ));
            }
        }

        public void RemoveRange(SupplierVisualInspection supplierVisualInspection)
        {
            if (supplierVisualInspection.Id != 0 && supplierVisualInspection.SupplierVisualInspectionDefectTypes.Count > 0)
            {
                var supplierVisualInspectionToRemove = this.Find(m => m.SupplierVisualInspectionId == supplierVisualInspection.Id);
                if (supplierVisualInspectionToRemove != null)
                {
                    this.RemoveRange(supplierVisualInspectionToRemove);
                }
            }
            else if (supplierVisualInspection.Id != 0 && supplierVisualInspection.SupplierVisualInspectionDefectTypes != null && supplierVisualInspection.SupplierVisualInspectionDefectTypes.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierVisualInspectionId == supplierVisualInspection.Id));
            }
        }
    }
}
