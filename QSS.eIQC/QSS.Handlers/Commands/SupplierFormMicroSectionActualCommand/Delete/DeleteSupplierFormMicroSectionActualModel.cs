/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionActualCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormMicroSectionActual operation
    /// </summary>
    public class DeleteSupplierFormMicroSectionActualModel : IRequest<DeleteSupplierFormMicroSectionActualResponse>
    {
        /// <summary>
        /// SupplierFormMicroSectionActual Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
