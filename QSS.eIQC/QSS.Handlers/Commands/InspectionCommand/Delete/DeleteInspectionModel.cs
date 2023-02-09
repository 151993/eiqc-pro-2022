/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Inspection operation
    /// </summary>
    public class DeleteInspectionModel : IRequest<DeleteInspectionResponse>
    {
        /// <summary>
        /// Inspection Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
