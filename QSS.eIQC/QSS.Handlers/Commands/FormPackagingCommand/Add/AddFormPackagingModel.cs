/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Add
{
    /// <summary>
    /// Representation model for Add FormPackaging operation
    /// </summary>
    public class AddFormPackagingModel : BaseCommand, IRequest<FormPackagingModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

        /// <summary>
        /// Get or set ResultDesc property
        /// </summary>        
        public string ResultDesc { get; set; }

        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public bool? Result { get; set; }

    }
}
