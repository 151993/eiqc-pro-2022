/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Update
{
    /// <summary>
    /// Representation model for Update InstrumentType operation
    /// </summary>
    public class UpdateInstrumentTypeModel : BaseUpdateCommand<int>, IRequest<InstrumentTypeModel>
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
