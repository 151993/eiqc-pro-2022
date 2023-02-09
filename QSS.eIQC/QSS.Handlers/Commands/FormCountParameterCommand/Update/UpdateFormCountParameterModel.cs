/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormCountParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update FormCountParameter operation
    /// </summary>
    public class UpdateFormCountParameterModel : BaseUpdateCommand<int>, IRequest<FormCountParameterModel>
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
        /// Get or set FailedQTYExpected property
        /// </summary>        
        public int? FailedQTYExpected { get; set; }

        /// <summary>
        /// Get or set FailedQTYActual property
        /// </summary>        
        public int? FailedQTYActual { get; set; }




        /// <summary>
        /// Get or set InspectionToolsId property
        /// </summary>        
        public int? InspectionToolsId { get; set; }

        /// <summary>
        /// Get or set Remark property
        /// </summary>        
        public string Remark { get; set; }

        /// <summary>
        /// Get or set InspectionDetails property
        /// </summary>        
        public string InspectionDetails { get; set; }

    }
}
