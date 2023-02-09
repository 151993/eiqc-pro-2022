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
    public class SupplierSapBasedParameterDefectTypeRepository : Repository<SupplierSapBasedParameterDefectType, int>, ISupplierSapBasedParameterDefectTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierSapBasedParameterDefectTypeRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="SupplierSapBasedParameter">supplierSapBasedParameter object</param>
        /// <param name="addedDefectTypeIds">List of DefectType Ids to be added</param>
        public void AddSupplierSapBasedParameterDefectTypes(SupplierSapBasedParameter supplierSapBasedParameter, List<int> defectTypeIds)
        {
            if (defectTypeIds != null && defectTypeIds.IsAny())
            {
                AddRange(defectTypeIds.Select(r =>
                   new SupplierSapBasedParameterDefectType()
                   {
                       SupplierSapBasedParameter = supplierSapBasedParameter,
                       DefectTypeId = r
                   }
                ));
            }
        }

        public void RemoveRange(SupplierSapBasedParameter supplierSapBasedParameter)
        {
            if (supplierSapBasedParameter.Id != 0 && supplierSapBasedParameter.SupplierSapBasedParameterDefectTypes.Count > 0)
            {
                var supplierSapBasedParameterToRemove = this.Find(m => m.SupplierSapBasedParameterId == supplierSapBasedParameter.Id);
                if (supplierSapBasedParameterToRemove != null)
                {
                    this.RemoveRange(supplierSapBasedParameterToRemove);
                }
            }
            else if (supplierSapBasedParameter.Id != 0 && supplierSapBasedParameter.SupplierSapBasedParameterDefectTypes != null && supplierSapBasedParameter.SupplierSapBasedParameterDefectTypes.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierSapBasedParameterId == supplierSapBasedParameter.Id));
            }
        }
    }
}
