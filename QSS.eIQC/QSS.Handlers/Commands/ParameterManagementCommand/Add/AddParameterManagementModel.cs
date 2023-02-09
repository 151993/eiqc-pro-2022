/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Add
{
    /// <summary>
    /// Representation model for Add ParameterManagement operation
    /// </summary>
    public class AddParameterManagementModel : BaseCommand, IRequest<ParameterManagementModel>
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

        /// <summary>
        /// Get or set AddedCommodityNameIds property
        /// </summary>
        public List<int> AddedCommodityNameIds { get; set; }

    }
}
