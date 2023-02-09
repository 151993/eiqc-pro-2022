/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormFunParaActual operation
    /// </summary>
    public class DeleteSupplierFormFunParaActualModel : IRequest<DeleteSupplierFormFunParaActualResponse>
    {
        /// <summary>
        /// SupplierFormFunParaActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
