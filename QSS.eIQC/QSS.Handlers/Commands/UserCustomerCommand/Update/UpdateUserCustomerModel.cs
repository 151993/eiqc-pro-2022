/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Update
{
    /// <summary>
    /// Representation model for Update UserCustomer operation
    /// </summary>
    public class UpdateUserCustomerModel : BaseUpdateCommand<int>, IRequest<UserCustomerModel>
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
