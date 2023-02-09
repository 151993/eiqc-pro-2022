/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Update
{
    /// <summary>
    /// Representation model for Update ParameterManagement operation
    /// </summary>
    public class UpdateParameterManagementModel : BaseUpdateCommand<int>, IRequest<ParameterManagementModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Get or set ParameterTypeCodeId property
        /// </summary>        
        public int ParameterTypeCodeId { get; set; }

        public List<int> AddedCommodityNameIds { get; set; }

        public List<int> RemovedCommodityNameIds { get; set; }

    }
}
