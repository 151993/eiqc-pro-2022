/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SupplierMeasurementSubmission operation
    /// </summary>
    public class DeleteSupplierMeasurementSubmissionModel : IRequest<DeleteSupplierMeasurementSubmissionResponse>
    {
        /// <summary>
        /// SupplierMeasurementSubmission Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
