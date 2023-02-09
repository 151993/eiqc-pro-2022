/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormFunParaActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormFunParaActual operation
    /// </summary>
    public class DeleteFormFunParaActualModel : IRequest<DeleteFormFunParaActualResponse>
    {
        /// <summary>
        /// FormFunParaActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
