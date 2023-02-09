/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Update
{
    /// <summary>
    /// Representation model for Update Role operation
    /// </summary>
    public class UpdateBuyerModel : BaseUpdateCommand<int>, IRequest<BuyerModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set BuyerCode property
        /// </summary>        
        public string BuyerCode { get; set; }
        /// <summary>
        /// Get or set BuyerMail property
        /// </summary>        
        public string BuyerMail { get; set; }
        /// <summary>
        /// Get or set IsValid property
        /// </summary>        
        public bool IsValid { get; set; }

    }
}
