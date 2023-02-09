/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Delete
{
    /// <summary>
    /// Representation model for Delete AdminCertification operation
    /// </summary>
    public class DeleteAdminCertificationModel : IRequest<DeleteAdminCertificationResponse>
    {
        /// <summary>
        /// AdminCertification Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
