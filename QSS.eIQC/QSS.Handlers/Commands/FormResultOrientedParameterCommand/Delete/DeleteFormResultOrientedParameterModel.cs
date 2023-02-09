/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormResultOrientedParameter operation
    /// </summary>
    public class DeleteFormResultOrientedParameterModel : IRequest<DeleteFormResultOrientedParameterResponse>
    {
        /// <summary>
        /// FormResultOrientedParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
