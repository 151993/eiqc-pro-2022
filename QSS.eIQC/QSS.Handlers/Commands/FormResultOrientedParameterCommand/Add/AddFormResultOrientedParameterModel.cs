/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Add
{
    /// <summary>
    /// Representation model for Add FormResultOrientedParameter operation
    /// </summary>
    public class AddFormResultOrientedParameterModel : BaseCommand, IRequest<FormResultOrientedParameterModel>
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
        /// Get or set ResultActual property
        /// </summary>        
        public bool? ResultActual { get; set; }

        /// <summary>
        /// Get or set TestCondition property
        /// </summary>        
        public string TestCondition { get; set; }

        /// <summary>
        /// Get or set InspectionDetails property
        /// </summary>        
        public string InspectionDetails { get; set; }

    }
}
