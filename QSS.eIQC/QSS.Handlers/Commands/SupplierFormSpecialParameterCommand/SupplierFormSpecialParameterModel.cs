/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand
{
    /// <summary>
    /// Representation model for SupplierFormSpecialParameter entity
    /// </summary>
    public class SupplierFormSpecialParameterModel : BaseStausModel<int>
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
        /// Get or set ParameterName property
        /// </summary>        
        public string ParameterName { get; set; }



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
