/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Update
{
    /// <summary>
    /// Representation model for Update ParameterCategory operation
    /// </summary>
    public class UpdateParameterCategoryModel : BaseUpdateCommand<int>, IRequest<ParameterCategoryModel>
    {
        /// <summary>
        /// Get or set Sequence property
        /// </summary>        
        public int? Sequence { get; set; }

        /// <summary>
        /// Get or set MultiSampling property
        /// </summary>        
        public int? MultiSampling { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }




        /// <summary>
        /// Get or set PCCodeId property
        /// </summary>        
        public int? PCCodeId { get; set; }

    }
}
