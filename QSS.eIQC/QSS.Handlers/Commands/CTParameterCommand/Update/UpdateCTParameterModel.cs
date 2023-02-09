/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CTParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update CTParameter operation
    /// </summary>
    public class UpdateCTParameterModel : BaseUpdateCommand<int>, IRequest<CTParameterModel>
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
