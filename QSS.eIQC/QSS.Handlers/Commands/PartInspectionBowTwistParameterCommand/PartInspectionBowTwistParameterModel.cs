/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.Handlers.Commands.DataTypeCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.WarPageCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand
{
    /// <summary>
    /// Representation model for PartBowTwistParameter entity
    /// </summary>
    public class PartInspectionBowTwistParameterModel : BaseStausModel<int>
    {

        public int SAPPartInspectionPlanId { get; set; }

        public int BowTwistFormulaId { get; set; }

        public int? WarPageTypeId { get; set; }

        public virtual BowTwistFormulaModel BowTwistFormula { get; set; }

        public decimal Spec { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public string Unit { get; set; }

        public decimal UpperLimit { get; set; }

    }
}
