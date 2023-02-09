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
    public class SupplierFunctionAttributeActualRepository : Repository<SupplierFunctionAttributeActual, int>, ISupplierFunctionAttributeActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFunctionAttributeActualRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="supplierFunctionAttribute">supplierFunctionAttribute object</param>
        /// <param name="FunctionAttributeActual">List of FunctionAttributeActual </param>
        public void AddSupplierFunctionAttributeActuals(SupplierFunctionAttribute supplierFunctionAttribute, IEnumerable<SupplierFunctionAttributeActual> FunctionAttributeActual)
        {
            supplierFunctionAttribute.SupplierFunctionAttributeActuals.Clear();
            if (FunctionAttributeActual != null && FunctionAttributeActual.Count() > 0)
            {
                AddRange(FunctionAttributeActual.Select(r =>
                   new SupplierFunctionAttributeActual()
                   {
                       SupplierFunctionAttribute = supplierFunctionAttribute,
                       ActualTextName = r.ActualTextName,
                       ActualTextValue = r.ActualTextValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierFunctionAttribute supplierFunctionAttribute)
        {
            if (supplierFunctionAttribute.Id != 0 && supplierFunctionAttribute.SupplierFunctionAttributeActuals.Count > 0)
            {
                var supplierFunctionAttributeToRemove = this.Find(m => m.SupplierFunctionAttributeId == supplierFunctionAttribute.Id);
                if (supplierFunctionAttributeToRemove != null)
                {
                    this.RemoveRange(supplierFunctionAttributeToRemove);
                }
            }
            else if (supplierFunctionAttribute.Id != 0 && supplierFunctionAttribute.SupplierFunctionAttributeActuals != null && supplierFunctionAttribute.SupplierFunctionAttributeActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierFunctionAttributeId == supplierFunctionAttribute.Id));
            }
        }
    }
}
