/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddSupplierFormVISModel : BaseCommand, IRequest<SupplierFormVISModel>
    {
        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }
        /// <summary>
        /// Get or set AcceptanceQTY property
        /// </summary>        
        public byte AcceptanceQTY { get; set; }
        /// <summary>
        /// Get or set TotalFailedQTY property
        /// </summary>        
        public byte TotalFailedQTY { get; set; }
    }
}
