/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormTestReportCommand.Update
{
    /// <summary>
    /// Representation model for Update FormTestReport operation
    /// </summary>
    public class UpdateFormTestReportModel : BaseUpdateCommand<int>, IRequest<FormTestReportModel>
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
        /// Get or set ResultExpected property
        /// </summary>        
        public bool ResultExpected { get; set; }

        /// <summary>
        /// Get or set TestCondition property
        /// </summary>        
        public string TestCondition { get; set; }

        /// <summary>
        /// Get or set ResultActual property
        /// </summary>        
        public bool? ResultActual { get; set; }

    }
}
