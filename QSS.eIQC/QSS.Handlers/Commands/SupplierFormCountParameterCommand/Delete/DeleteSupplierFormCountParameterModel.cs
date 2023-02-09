/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormCountParameter operation
    /// </summary>
    public class DeleteSupplierFormCountParameterModel : IRequest<DeleteSupplierFormCountParameterResponse>
    {
        /// <summary>
        /// SupplierFormCountParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
