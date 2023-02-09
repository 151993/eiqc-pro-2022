/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddUserCustomerModel : BaseCommand, IRequest<UserCustomerModel>
    {
        /// <summary>
        /// Get or set UserId property
        /// </summary>        
        public byte UserId { get; set; }
        /// <summary>
        /// Get or set CustomerId property
        /// </summary>        
        public byte CustomerId { get; set; }
    }
}
