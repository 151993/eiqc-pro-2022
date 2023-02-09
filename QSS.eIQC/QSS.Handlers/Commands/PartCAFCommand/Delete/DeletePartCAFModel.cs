/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Delete
{
    /// <summary>
    /// Representation model for Delete PartCAF operation
    /// </summary>
    public class DeletePartCAFModel : IRequest<DeletePartCAFResponse>
    {
        /// <summary>
        /// PartCAF Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
