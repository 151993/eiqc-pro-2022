/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Update
{
    /// <summary>
    /// Representation model for Update FormPackaging operation
    /// </summary>
    public class UpdateFormPackagingModel : BaseUpdateCommand<int>, IRequest<FormPackagingModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

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
