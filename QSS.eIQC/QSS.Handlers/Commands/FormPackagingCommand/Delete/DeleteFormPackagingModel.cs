/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormPackaging operation
    /// </summary>
    public class DeleteFormPackagingModel : IRequest<DeleteFormPackagingResponse>
    {
        /// <summary>
        /// FormPackaging Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
