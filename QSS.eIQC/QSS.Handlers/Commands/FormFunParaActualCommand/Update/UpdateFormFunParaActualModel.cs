/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Update
{
    /// <summary>
    /// Representation model for Update FormFunParaActual operation
    /// </summary>
    public class UpdateFormFunParaActualModel : BaseUpdateCommand<int>, IRequest<FormFunParaActualModel>
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
        /// Get or set No property
        /// </summary>        
        public int No { get; set; }

        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double? ValueActual { get; set; }


    }
}
