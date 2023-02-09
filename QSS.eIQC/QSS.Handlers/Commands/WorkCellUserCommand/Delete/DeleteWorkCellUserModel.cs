/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Delete
{
    /// <summary>
    /// Representation model for Delete WorkCellUser operation
    /// </summary>
    public class DeleteWorkCellUserModel : IRequest<DeleteWorkCellUserResponse>
    {
        /// <summary>
        /// WorkCellUser Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
