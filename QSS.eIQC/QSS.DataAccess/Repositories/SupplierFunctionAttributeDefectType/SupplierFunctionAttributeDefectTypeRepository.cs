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
    public class SupplierFunctionAttributeDefectTypeRepository : Repository<SupplierFunctionAttributeDefectType, int>, ISupplierFunctionAttributeDefectTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFunctionAttributeDefectTypeRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierFunctionAttributeDefectTypes(SupplierFunctionAttribute supplierFunctionAttribute, List<int> defectTypeIds)
        {
            if (defectTypeIds != null && defectTypeIds.IsAny())
            {
                AddRange(defectTypeIds.Select(r =>
                   new SupplierFunctionAttributeDefectType()
                   {
                       SupplierFunctionAttribute = supplierFunctionAttribute,
                       DefectTypeId = r
                   }
                ));
            }
        }

        public void RemoveRange(SupplierFunctionAttribute supplierFunctionAttribute)
        {
            if (supplierFunctionAttribute.Id != 0 && supplierFunctionAttribute.SupplierFunctionAttributeDefectTypes.Count > 0)
            {
                var supplierFunctionAttributeToRemove = this.Find(m => m.SupplierFunctionAttributeId == supplierFunctionAttribute.Id);
                if (supplierFunctionAttributeToRemove != null)
                {
                    this.RemoveRange(supplierFunctionAttributeToRemove);
                }
            }
            else if (supplierFunctionAttribute.Id != 0 && supplierFunctionAttribute.SupplierFunctionAttributeDefectTypes != null && supplierFunctionAttribute.SupplierFunctionAttributeDefectTypes.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierFunctionAttributeId == supplierFunctionAttribute.Id));
            }
        }
    }
}
