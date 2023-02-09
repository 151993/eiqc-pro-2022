/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddInstrumentTypeModel : BaseCommand, IRequest<InstrumentTypeModel>
    {
        /// <summary>
        /// Get or set Code property
        /// </summary>        
        public string Code { get; set; }
        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

    }
}
