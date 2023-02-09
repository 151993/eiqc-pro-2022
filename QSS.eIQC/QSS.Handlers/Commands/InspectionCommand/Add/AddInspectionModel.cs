/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Add
{
    /// <summary>
    /// Representation model for Add Inspection operation
    /// </summary>
    public class AddInspectionModel : BaseCommand, IRequest<InspectionModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

        /// <summary>
        /// Get or set Inspector property
        /// </summary>        
        public string Inspector { get; set; }

        /// <summary>
        /// Get or set InspectionResult property
        /// </summary>        
        public string InspectionResult { get; set; }

        /// <summary>
        /// Get or set ReportFullName property
        /// </summary>        
        public string ReportFullName { get; set; }


    }
}
