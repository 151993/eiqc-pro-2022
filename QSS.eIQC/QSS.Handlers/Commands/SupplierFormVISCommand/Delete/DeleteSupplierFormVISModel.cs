/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierFormVIS operation
    /// </summary>
    public class DeleteSupplierFormVISModel : IRequest<DeleteSupplierFormVISResponse>
    {
        /// <summary>
        /// SupplierFormVIS Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
