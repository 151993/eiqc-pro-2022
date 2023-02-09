/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormMicroSectionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormMicroSection operation
    /// </summary>
    public class DeleteFormMicroSectionModel : IRequest<DeleteFormMicroSectionResponse>
    {
        /// <summary>
        /// FormMicroSection Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
