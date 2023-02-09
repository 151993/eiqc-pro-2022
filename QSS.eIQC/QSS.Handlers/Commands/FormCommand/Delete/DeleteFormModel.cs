/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Form operation
    /// </summary>
    public class DeleteFormModel : IRequest<DeleteFormResponse>
    {
        /// <summary>
        /// Form Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
