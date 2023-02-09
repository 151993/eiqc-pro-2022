/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand.Add
{
    /// <summary>
    /// Representation model for Add FormStatus operation
    /// </summary>
    public class AddFormStatusModel : BaseCommand, IRequest<FormStatusModel>
    {



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }

        /// <summary>
        /// Get or set StatusID property
        /// </summary>        
        public string StatusID { get; set; }

        /// <summary>
        /// Get or set UserName property
        /// </summary>        
        public string UserName { get; set; }

        /// <summary>
        /// Get or set LastTime property
        /// </summary>        
        public DateTimeOffset LastTime { get; set; }

    }
}
