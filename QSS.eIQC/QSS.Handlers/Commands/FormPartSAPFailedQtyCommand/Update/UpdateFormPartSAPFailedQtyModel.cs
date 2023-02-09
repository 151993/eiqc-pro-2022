/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Update
{
    /// <summary>
    /// Representation model for Update FormPartSAPFailedQty operation
    /// </summary>
    public class UpdateFormPartSAPFailedQtyModel : BaseUpdateCommand<int>, IRequest<FormPartSAPFailedQtyModel>
    {
        /// <summary>
        /// Get or set GRSNo property
        /// </summary>        
        public string GRSNo { get; set; }

        /// <summary>
        /// Get or set PCCode property
        /// </summary>        
        public string PCCode { get; set; }

        /// <summary>
        /// Get or set FailedQty property
        /// </summary>        
        public int? FailedQty { get; set; }

    }
}
