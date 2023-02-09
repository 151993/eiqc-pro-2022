/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddBuyerModel : BaseCommand, IRequest<BuyerModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string BuyerCode { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string BuyerMail { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public bool IsValid { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public StatusType StatusType { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public byte StatusTypeId { get; set; }

    }
}
