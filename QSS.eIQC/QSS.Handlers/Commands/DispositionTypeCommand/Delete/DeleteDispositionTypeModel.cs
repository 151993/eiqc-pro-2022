/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete DispositionType operation
    /// </summary>
    public class DeleteDispositionTypeModel : IRequest<DeleteDispositionTypeResponse>
    {
        /// <summary>
        /// DispositionType Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
