/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Delete
{
    /// <summary>
    /// Representation model for Delete CertificateType operation
    /// </summary>
    public class DeleteCertificateTypeModel : IRequest<DeleteCertificateTypeResponse>
    {
        /// <summary>
        /// CertificateType Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
