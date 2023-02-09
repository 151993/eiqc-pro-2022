/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Delete
{
    /// <summary>
    /// Representation model for Delete UOM operation
    /// </summary>
    public class DeleteUOMModel : IRequest<DeleteUOMResponse>
    {
        /// <summary>
        /// UOM Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
