/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update
{
    /// <summary>
    /// Representation model for Update BowTwistFormula operation
    /// </summary>
    public class UpdateBowTwistFormulaModel : BaseUpdateCommand<int>, IRequest<BowTwistFormulaModel>
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
