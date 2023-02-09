/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddSupplierFormPackagingModel : BaseCommand, IRequest<SupplierFormPackagingModel>
    {
        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }
        /// <summary>
        /// Get or set ResultDesc property
        /// </summary>        
        public string ResultDesc { get; set; }
        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public bool Result { get; set; }
    }
}
