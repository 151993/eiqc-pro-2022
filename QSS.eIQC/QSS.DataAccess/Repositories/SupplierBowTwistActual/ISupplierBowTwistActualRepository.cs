using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Site Division 
    /// </summary>
    public interface ISupplierBowTwistActualRepository
    {
        void AddSupplierBowTwistActuals(SupplierBowTwist supplierBowTwist, IEnumerable<SupplierBowTwistActual> bowTwistActuals);
        
        void RemoveRange(SupplierBowTwist supplierBowTwist);
    }
}
