/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Buyer operation
    /// </summary>
    public class DeleteBuyerModel : IRequest<DeleteBuyerResponse>
    {
        /// <summary>
        /// Buyer Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
