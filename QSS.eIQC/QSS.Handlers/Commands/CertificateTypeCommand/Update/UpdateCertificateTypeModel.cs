/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Update
{
    /// <summary>
    /// Representation model for Update CertificateType operation
    /// </summary>
    public class UpdateCertificateTypeModel : BaseUpdateCommand<int>, IRequest<CertificateTypeModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set AddedCertificateTypeParameters property
        /// </summary>
        public List<string> AddedCertificateTypeParameters { get; set; }

        /// <summary>
        /// Get or set RemovedCertificateTypeParameters property
        /// </summary>
        public List<string> RemovedCertificateTypeParameters { get; set; }
    }
}
