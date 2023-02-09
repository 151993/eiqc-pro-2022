/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormSAPParameter operation
    /// </summary>
    public class DeleteSupplierFormSAPParameterModel : IRequest<DeleteSupplierFormSAPParameterResponse>
    {
        /// <summary>
        /// SupplierFormSAPParameter Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
