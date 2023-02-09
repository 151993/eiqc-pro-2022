/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Update
{
    /// <summary>
    /// Representation model for Update CommodityCategory operation
    /// </summary>
    public class UpdateCommodityCategoryModel : BaseUpdateCommand<int>, IRequest<CommodityCategoryModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set CommodityCategoryTypeId property
        /// </summary>        
        public int? CommodityCategoryTypeId { get; set; }

        public int? CommodityCategoryOptionId { get; set; }
    }
}
