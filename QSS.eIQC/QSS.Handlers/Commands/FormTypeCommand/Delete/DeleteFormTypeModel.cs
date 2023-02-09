/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormTypeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormType operation
    /// </summary>
    public class DeleteFormTypeModel : IRequest<DeleteFormTypeResponse>
    {
        /// <summary>
        /// FormType Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
