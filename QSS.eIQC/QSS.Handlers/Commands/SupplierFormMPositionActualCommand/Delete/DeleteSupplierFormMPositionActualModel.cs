/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormMPositionActual operation
    /// </summary>
    public class DeleteSupplierFormMPositionActualModel : IRequest<DeleteSupplierFormMPositionActualResponse>
    {
        /// <summary>
        /// SupplierFormMPositionActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
