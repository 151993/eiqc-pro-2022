/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands
{
    /// <summary>
    /// Representation model for PartResultOrientedParameter entity
    /// </summary>
    public class SupplierBowTwistModel : BaseStausModel<int>
    {
        public int SupplierBowTwistId { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int PartBowTwistParameterId { get; set; }

        public virtual PartInspectionBowTwistParameterModel PartInspectionBowTwistParameter { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public virtual IEnumerable<SupplierBowTwistActualModel> SupplierBowTwistActuals { get; set; }

        public virtual BowTwistFormulaModel BowTwistFormulas { get; set; }

    }
}
