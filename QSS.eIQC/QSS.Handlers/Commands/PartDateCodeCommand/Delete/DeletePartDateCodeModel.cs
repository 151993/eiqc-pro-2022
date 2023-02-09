/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete DateCode operation
    /// </summary>
    public class DeletePartDateCodeModel : IRequest<DeletePartDateCodeResponse>
    {
        /// <summary>
        /// DateCode Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
