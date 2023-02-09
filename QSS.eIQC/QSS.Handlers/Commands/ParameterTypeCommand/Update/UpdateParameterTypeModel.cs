/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Update
{
    /// <summary>
    /// Representation model for Update ParameterType operation
    /// </summary>
    public class UpdateParameterTypeModel : BaseUpdateCommand<int>, IRequest<ParameterTypeModel>
    {
        /// <summary>
        /// Get or set Code property
        /// </summary>        
        public string Code { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Get or set ComparationMethodDescription property
        /// </summary>        
        public string ComparationMethodDescription { get; set; }

    }
}
