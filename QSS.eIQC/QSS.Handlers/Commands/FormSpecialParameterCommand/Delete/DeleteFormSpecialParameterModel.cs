/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormSpecialParameter operation
    /// </summary>
    public class DeleteFormSpecialParameterModel : IRequest<DeleteFormSpecialParameterResponse>
    {
        /// <summary>
        /// FormSpecialParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
