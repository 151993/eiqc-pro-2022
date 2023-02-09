/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.RosettaCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddRosettaModel : BaseCommand, IRequest<RosettaModel>
    {
        /// <summary>
        /// Get or set EN_US property
        /// </summary>        
        public string EN_US { get; set; }
        /// <summary>
        /// Get or set ZH_CN property
        /// </summary>        
        public string ZH_CN { get; set; }
    }
}
