/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Add
{
    /// <summary>
    /// Representation model for Add FormType operation
    /// </summary>
    public class AddFormTypeModel : BaseCommand, IRequest<FormTypeModel>
    {
        /// <summary>
        /// Get or set FormTypeId property
        /// </summary>        
        public int FormTypeId { get; set; }

        /// <summary>
        /// Get or set Type property
        /// </summary>        
        public string Type { get; set; }


    }
}
