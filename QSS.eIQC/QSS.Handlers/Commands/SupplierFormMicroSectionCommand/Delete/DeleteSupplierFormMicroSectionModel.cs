/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormMicroSection operation
    /// </summary>
    public class DeleteSupplierFormMicroSectionModel : IRequest<DeleteSupplierFormMicroSectionResponse>
    {
        /// <summary>
        /// SupplierFormMicroSection Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
