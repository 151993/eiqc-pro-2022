/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Add
{
    /// <summary>
    /// Representation model for Add SupplierAttachment operation
    /// </summary>
    public class AddSupplierAttachmentModel : BaseCommand, IRequest<SupplierAttachmentModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set ATType property
        /// </summary>        
        public string ATType { get; set; }

        /// <summary>
        /// Get or set Path property
        /// </summary>        
        public string Path { get; set; }

   }
}
