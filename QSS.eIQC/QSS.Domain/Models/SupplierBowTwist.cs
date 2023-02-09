/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierTestReport entity model to map database SupplierTestReport table 
    /// </summary>
    public class SupplierBowTwist : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierBowTwist()
        {
            this.SupplierBowTwistActuals = new HashSet<SupplierBowTwistActual>();
        }

        public int SupplierMeasurementSubmissionId { get; set; }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }

        public int PartBowTwistParameterId { get; set; }

        public virtual PartInspectionBowTwistParameter PartInspectionBowTwistParameter { get; set; }

        public virtual ICollection<SupplierBowTwistActual> SupplierBowTwistActuals { get; set; }


    }
}
