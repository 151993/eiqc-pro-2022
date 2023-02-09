/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartDimensionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete PartDimension operation
    /// </summary>
    public class DeletePartDimensionModel : IRequest<DeletePartDimensionResponse>
    {
        /// <summary>
        /// PartDimension Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
