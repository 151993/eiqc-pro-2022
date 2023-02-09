/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierBowTwistActual entity model to map database SupplierBowTwistActual table 
    /// </summary>
    public class SupplierBowTwistActual : PersistentObjectWithUpdate<int>
    {
        public SupplierBowTwistActual()
        {
        }

        public int SupplierBowTwistId { get; set; }

        public virtual SupplierBowTwist SupplierBowTwist { get; set; }

        public string ActualTextName { get; set; }

        public string ActualTextValue { get; set; }

    }
}
