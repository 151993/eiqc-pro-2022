/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.GRSCommand.Delete
{
    /// <summary>
    /// Representation model for Delete GRS operation
    /// </summary>
    public class DeleteGRSModel : IRequest<DeleteGRSResponse>
    {
        /// <summary>
        /// GRS Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
