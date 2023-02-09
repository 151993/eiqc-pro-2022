/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Group operation
    /// </summary>
    public class DeleteGroupModel : IRequest<DeleteGroupResponse>
    {
        /// <summary>
        /// Group Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
