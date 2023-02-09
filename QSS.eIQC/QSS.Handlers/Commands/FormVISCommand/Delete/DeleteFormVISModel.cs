/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Delete
{
    /// <summary>
    /// Representation model for Delete FormVIS operation
    /// </summary>
    public class DeleteFormVISModel : IRequest<DeleteFormVISResponse>
    {
        /// <summary>
        /// FormVIS Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
