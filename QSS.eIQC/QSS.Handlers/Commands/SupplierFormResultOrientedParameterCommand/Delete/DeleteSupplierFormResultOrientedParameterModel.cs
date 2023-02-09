/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormResultOrientedParameter operation
    /// </summary>
    public class DeleteSupplierFormResultOrientedParameterModel : IRequest<DeleteSupplierFormResultOrientedParameterResponse>
    {
        /// <summary>
        /// SupplierFormResultOrientedParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
