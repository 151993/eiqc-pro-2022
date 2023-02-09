/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand
{
    /// <summary>
    /// Representation model for SupplierFormFunParaActual entity
    /// </summary>
    public class SupplierFormFunParaActualModel : BaseStausModel<int>
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
        /// Get or set No property
        /// </summary>        
        public int No { get; set; }



        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double? ValueActual { get; set; }

    }
}
