/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand
{
    /// <summary>
    /// Representation model for SupplierAttachment entity
    /// </summary>
    public class SupplierAttachmentModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set SupplierForm property
        /// </summary>        
        public SupplierFormModel SupplierForm { get; set; }



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
