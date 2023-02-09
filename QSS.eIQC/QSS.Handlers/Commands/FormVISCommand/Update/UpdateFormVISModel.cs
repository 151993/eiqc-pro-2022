/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Update
{
    /// <summary>
    /// Representation model for Update FormVIS operation
    /// </summary>
    public class UpdateFormVISModel : BaseUpdateCommand<int>, IRequest<FormVISModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

        /// <summary>
        /// Get or set AcceptanceQTY property
        /// </summary>        
        public int? AcceptanceQTY { get; set; }

        /// <summary>
        /// Get or set TotalFailedQTY property
        /// </summary>        
        public int? TotalFailedQTY { get; set; }

    }
}
