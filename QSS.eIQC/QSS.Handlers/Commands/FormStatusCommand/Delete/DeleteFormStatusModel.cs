/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormStatus operation
    /// </summary>
    public class DeleteFormStatusModel : IRequest<DeleteFormStatusResponse>
    {
        /// <summary>
        /// FormStatus Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
