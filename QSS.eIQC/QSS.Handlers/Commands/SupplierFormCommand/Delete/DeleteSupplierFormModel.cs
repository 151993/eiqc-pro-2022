/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierForm operation
    /// </summary>
    public class DeleteSupplierFormModel : IRequest<DeleteSupplierFormResponse>
    {
        /// <summary>
        /// SupplierForm Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
