/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.RosettaCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Rosetta operation
    /// </summary>
    public class DeleteRosettaModel : IRequest<DeleteRosettaResponse>
    {
        /// <summary>
        /// Rosetta Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
