/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormPartDateCode operation
    /// </summary>
    public class DeleteSupplierFormPartDateCodeModel : IRequest<DeleteSupplierFormPartDateCodeResponse>
    {
        /// <summary>
        /// SupplierFormPartDateCode Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
