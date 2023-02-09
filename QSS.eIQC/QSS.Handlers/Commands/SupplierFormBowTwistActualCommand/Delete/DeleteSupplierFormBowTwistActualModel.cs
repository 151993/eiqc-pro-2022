/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormBowTwistActual operation
    /// </summary>
    public class DeleteSupplierFormBowTwistActualModel : IRequest<DeleteSupplierFormBowTwistActualResponse>
    {
        /// <summary>
        /// SupplierFormBowTwistActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
