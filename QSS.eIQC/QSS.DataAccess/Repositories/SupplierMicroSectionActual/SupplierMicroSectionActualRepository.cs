using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for SupplierMicroSectionDefectType, provides Add, Update and Delete operations
    /// </summary>
    public class SupplierMicroSectionActualRepository : Repository<SupplierMicroSectionActual, int>, ISupplierMicroSectionActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierMicroSectionActualRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of defectTypeIds associated with Site in database.
        /// </summary>
        /// <param name="supplierMicroSection">supplierMicroSection object</param>
        /// <param name="microSectionActual">List of microSectionActual </param>
        public void AddSupplierMicroSectionActuals(SupplierMicrosection supplierMicroSection, IEnumerable<SupplierMicroSectionActual> microSectionActual)
        {
            supplierMicroSection.SupplierMicroSectionActuals.Clear();
            if (microSectionActual != null && microSectionActual.Count() > 0)
            {
                AddRange(microSectionActual.Select(r =>
                   new SupplierMicroSectionActual()
                   {
                       SupplierMicrosection = supplierMicroSection,
                       ActualTextName = r.ActualTextName,
                       ActualTextValue = r.ActualTextValue
                   }
                ));
            }
        }

        public void RemoveRange(SupplierMicrosection supplierMicroSection)
        {
            if (supplierMicroSection.Id != 0 && supplierMicroSection.SupplierMicroSectionActuals.Count > 0)
            {
                var supplierMicroSectionToRemove = this.Find(m => m.SupplierMicrosectionId == supplierMicroSection.Id);
                if (supplierMicroSectionToRemove != null)
                {
                    this.RemoveRange(supplierMicroSectionToRemove);
                }
            }
            else if (supplierMicroSection.Id != 0 && supplierMicroSection.SupplierMicroSectionActuals != null && supplierMicroSection.SupplierMicroSectionActuals.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SupplierMicrosectionId == supplierMicroSection.Id));
            }
        }
    }
}
