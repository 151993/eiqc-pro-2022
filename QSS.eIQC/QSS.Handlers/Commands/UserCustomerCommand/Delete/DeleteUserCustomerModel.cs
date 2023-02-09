/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Delete
{
    /// <summary>
    /// Representation model for Delete UserCustomer operation
    /// </summary>
    public class DeleteUserCustomerModel : IRequest<DeleteUserCustomerResponse>
    {
        /// <summary>
        /// UserCustomer Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
