/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Update
{
    /// <summary>
    /// Representation model for Update Inspection operation
    /// </summary>
    public class UpdateInspectionModel : BaseUpdateCommand<int>, IRequest<InspectionModel>
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
