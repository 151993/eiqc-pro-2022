/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Add
{
    /// <summary>
    /// Representation model for Add FormVIS operation
    /// </summary>
    public class AddFormVISModel : BaseCommand, IRequest<FormVISModel>
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
