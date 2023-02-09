/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Update
{
    /// <summary>
    /// Representation model for Update ParameterTypeCode operation
    /// </summary>
    public class UpdateParameterTypeCodeModel : BaseUpdateCommand<int>, IRequest<ParameterTypeCodeModel>
    {

        /// <summary>
        /// Get or set ParameterManagementTypeId property
        /// </summary>        
        public int ParameterManagementTypeId { get; set; }

        public List<int> AddedPcCodeIds { get; set; }

        public List<int> RemovedPcCodeIds { get; set; }

        /// <summary>
        /// Get or set Name property
        /// </summary> 
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

    }
}
