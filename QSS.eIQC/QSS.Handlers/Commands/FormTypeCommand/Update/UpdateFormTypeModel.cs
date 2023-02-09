/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Update
{
    /// <summary>
    /// Representation model for Update FormType operation
    /// </summary>
    public class UpdateFormTypeModel : BaseUpdateCommand<int>, IRequest<FormTypeModel>
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
