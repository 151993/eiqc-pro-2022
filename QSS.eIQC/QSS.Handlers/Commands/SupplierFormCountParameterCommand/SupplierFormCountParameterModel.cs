/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand
{
    /// <summary>
    /// Representation model for SupplierFormCountParameter entity
    /// </summary>
    public class SupplierFormCountParameterModel : BaseStausModel<int>
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
        /// Get or set FailedQTYExpected property
        /// </summary>        
        public int? FailedQTYExpected { get; set; }



        /// <summary>
        /// Get or set FailedQTYActual property
        /// </summary>        
        public int? FailedQTYActual { get; set; }



        /// <summary>
        /// Get or set IToolsID property
        /// </summary>        
        public int? IToolsID { get; set; }



        /// <summary>
        /// Get or set Remark property
        /// </summary>        
        public string Remark { get; set; }



        /// <summary>
        /// Get or set InspectionDetails property
        /// </summary>        
        public string InspectionDetails { get; set; }

    }
}
