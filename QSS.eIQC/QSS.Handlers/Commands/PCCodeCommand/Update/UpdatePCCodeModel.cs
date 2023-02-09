/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Update
{
    /// <summary>
    /// Representation model for Update PCCode operation
    /// </summary>
    public class UpdatePCCodeModel : BaseUpdateCommand<int>, IRequest<PCCodeModel>
    {
        /// <summary>
        /// Get or set PCCode property
        /// </summary>        
        public string Code { get; set; }

        /// <summary>
        /// Get or set Hyperlink property
        /// </summary>        
        public string Description { get; set; }

    }
}
