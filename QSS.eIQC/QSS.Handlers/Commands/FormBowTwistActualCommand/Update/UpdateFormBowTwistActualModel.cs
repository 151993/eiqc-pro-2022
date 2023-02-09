/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand.Update
{
    /// <summary>
    /// Representation model for Update FormBowTwistActual operation
    /// </summary>
    public class UpdateFormBowTwistActualModel : BaseUpdateCommand<int>, IRequest<FormBowTwistActualModel>
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
        /// Get or set SAPParameterExpected property
        /// </summary>        
        public string SAPParameterExpected { get; set; }

        /// <summary>
        /// Get or set SAPParameterActual property
        /// </summary>        
        public string SAPParameterActual { get; set; }


    }
}
