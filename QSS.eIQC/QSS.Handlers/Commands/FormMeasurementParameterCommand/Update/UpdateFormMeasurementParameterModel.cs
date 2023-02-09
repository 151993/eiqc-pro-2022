/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormMeasurementParameterCommand.Update
{
    /// <summary>
    /// Representation model for Update FormMeasurementParameter operation
    /// </summary>
    public class UpdateFormMeasurementParameterModel : BaseUpdateCommand<int>, IRequest<FormMeasurementParameterModel>
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
        /// Get or set InstrumentId property
        /// </summary>        
        public int? InstrumentId { get; set; }

        /// <summary>
        /// Get or set UOM property
        /// </summary>        
        public string UOM { get; set; }

        /// <summary>
        /// Get or set NormalValue property
        /// </summary>        
        public double? NormalValue { get; set; }

        /// <summary>
        /// Get or set UpperLimit property
        /// </summary>        
        public double UpperLimit { get; set; }

        /// <summary>
        /// Get or set LowerLimit property
        /// </summary>        
        public double LowerLimit { get; set; }

        /// <summary>
        /// Get or set Accuracy property
        /// </summary>        
        public int? Accuracy { get; set; }

        /// <summary>
        /// Get or set SampleSize property
        /// </summary>        
        public string SampleSize { get; set; }

    }
}
