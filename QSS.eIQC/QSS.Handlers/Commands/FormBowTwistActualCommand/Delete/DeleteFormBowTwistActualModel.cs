/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormBowTwistActual operation
    /// </summary>
    public class DeleteFormBowTwistActualModel : IRequest<DeleteFormBowTwistActualResponse>
    {
        /// <summary>
        /// FormBowTwistActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
