/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add
{
    /// <summary>
    /// Representation model for Add PartDimension operation
    /// </summary>
    public class AddPartDimensionModel : BaseCommand, IRequest<PartDimensionModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

    }
}
