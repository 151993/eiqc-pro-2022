
using EnumModel = QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand
{
    /// <summary>
    /// Representation model for BowTwistFormula entity
    /// </summary>
    public class BowTwistFormulaModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Equation property
        /// </summary>        
        public string Equation { get; set; }

        public int WarPageId { get; set; }

        public virtual EnumModel.WarPageModel WarPage { get; set; }

    }
}
