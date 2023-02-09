/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add
{
    /// <summary>
    /// Representation model for Add CertificateType operation
    /// </summary>
    public class AddCertificateTypeModel : BaseCommand, IRequest<CertificateTypeModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        public List<string> AddedCertificateTypeParameters { get; set; }


    }
}
