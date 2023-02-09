/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete PartBowTwistParameter operation
    /// </summary>
    public class DeletePartInspectionBowTwistParameterModel : IRequest<DeletePartInspectionBowTwistParameterResponse>
    {
        /// <summary>
        /// PartBowTwistParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
