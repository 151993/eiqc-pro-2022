/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Delete
{
    /// <summary>
    /// Representation model for Delete GRSSupplierForm operation
    /// </summary>
    public class DeleteGRSSupplierFormModel : IRequest<DeleteGRSSupplierFormResponse>
    {
        /// <summary>
        /// GRSSupplierForm Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
