/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete PCCode operation
    /// </summary>
    public class DeletePCCodeModel : IRequest<DeletePCCodeResponse>
    {
        /// <summary>
        /// PCCode Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
