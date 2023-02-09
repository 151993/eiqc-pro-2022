/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormMicroSectionActual operation
    /// </summary>
    public class DeleteFormMicroSectionActualModel : IRequest<DeleteFormMicroSectionActualResponse>
    {
        /// <summary>
        /// FormMicroSectionActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
