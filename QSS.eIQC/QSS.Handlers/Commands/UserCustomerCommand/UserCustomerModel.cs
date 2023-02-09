/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Commands.CustomerCommand;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand
{
    /// <summary>
    /// Representation model for UserCustomer entity
    /// </summary>
    public class UserCustomerModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set User property
        /// </summary>        
        public UserModel User { get; set; }



        /// <summary>
        /// Get or set UserId property
        /// </summary>        
        public byte UserId { get; set; }

        /// <summary>
        /// Get or set Customer property
        /// </summary>        
        public CustomerModel Customer { get; set; }



        /// <summary>
        /// Get or set CustomerId property
        /// </summary>        
        public byte CustomerId { get; set; }

        /// <summary>
        /// Get or set StatusType property
        /// </summary>        

   }
}
