/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFormVISCommand
{
    /// <summary>
    /// Representation model for SupplierFormVIS entity
    /// </summary>
    public class SupplierFormVISModel : BaseStausModel<int>
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
        /// Get or set AcceptanceQTY property
        /// </summary>        
        public int AcceptanceQTY { get; set; }



        /// <summary>
        /// Get or set TotalFailedQTY property
        /// </summary>        
        public int TotalFailedQTY { get; set; }

    }
}
