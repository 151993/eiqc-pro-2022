/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormPackaging operation
    /// </summary>
    public class DeleteSupplierFormPackagingModel : IRequest<DeleteSupplierFormPackagingResponse>
    {
        /// <summary>
        /// SupplierFormPackaging Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
