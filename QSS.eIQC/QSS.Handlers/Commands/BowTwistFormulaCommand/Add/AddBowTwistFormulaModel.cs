using MediatR;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add
{
    /// <summary>
    /// Representation model for Add BowTwistFormula operation
    /// </summary>
    public class AddBowTwistFormulaModel : BaseCommand, IRequest<BowTwistFormulaModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string? Name { get; set; }

        /// <summary>
        /// Get or set Equation property
        /// </summary>        
        public string? Equation { get; set; }

        public int WarPageId { get; set; }

    }
}
