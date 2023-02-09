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
    public class SupplierFunctionVariableActualRepository : BaseRepository<SupplierFunctionVariableActual, int>, ISupplierFunctionVariableActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierFunctionVariableActualRepository(QSSContext context) : base(context)
        {
        }

        public void AddSupplierFunctionVariableAcutals(SupplierFunctionVariable supplierFunctionVariable, IEnumerable<SupplierFunctionVariableActual> SupplierFunctionVariableActuals)
        {
            supplierFunctionVariable.SupplierFunctionVariableActuals.Clear();
            if (SupplierFunctionVariableActuals != null && SupplierFunctionVariableActuals.Count() > 0)
            {
                AddRange(SupplierFunctionVariableActuals.Select(r =>
                   new SupplierFunctionVariableActual()
                   {
                       SupplierFunctionVariable = supplierFunctionVariable,
                       ActualTextName = r.ActualTextName,
                       ActualTextValue = r.ActualTextValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierFunctionVariable supplierFunctionVariable)
        {
            if (supplierFunctionVariable.Id != 0 && supplierFunctionVariable.SupplierFunctionVariableActuals.Count > 0)
            {
                var SupplierBowTwistToRemove = this.Find(m => m.SupplierFunctionVariableId == supplierFunctionVariable.Id);
                if (SupplierBowTwistToRemove != null)
                {
                    this.RemoveRange(SupplierBowTwistToRemove);
                }
            }
            else if (supplierFunctionVariable.Id != 0 && supplierFunctionVariable.SupplierFunctionVariableActuals != null && supplierFunctionVariable.SupplierFunctionVariableActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierFunctionVariableId == supplierFunctionVariable.Id));
            }
        }
    }
}
