/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update FormSpecialParameter operation
    /// </summary>
    public class UpdateFormSpecialParameterModel : BaseUpdateCommand<int>, IRequest<FormSpecialParameterModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

        /// <summary>
        /// Get or set ParameterName property
        /// </summary>        
        public string ParameterName { get; set; }

        /// <summary>
        /// Get or set ResultDesc property
        /// </summary>        
        public string ResultDesc { get; set; }

        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public bool? Result { get; set; }

    }
}
