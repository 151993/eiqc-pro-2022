/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormPartSAPFailedQty operation
    /// </summary>
    public class DeleteFormPartSAPFailedQtyModel : IRequest<DeleteFormPartSAPFailedQtyResponse>
    {
        /// <summary>
        /// FormPartSAPFailedQty Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
