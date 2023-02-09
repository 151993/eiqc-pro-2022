/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMPositionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormMPosition operation
    /// </summary>
    public class DeleteSupplierFormMPositionModel : IRequest<DeleteSupplierFormMPositionResponse>
    {
        /// <summary>
        /// SupplierFormMPosition Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
