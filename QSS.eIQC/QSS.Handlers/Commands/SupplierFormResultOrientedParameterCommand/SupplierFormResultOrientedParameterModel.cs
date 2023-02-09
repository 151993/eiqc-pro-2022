/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand
{
    /// <summary>
    /// Representation model for SupplierFormResultOrientedParameter entity
    /// </summary>
    public class SupplierFormResultOrientedParameterModel : BaseStausModel<int>
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
        /// Get or set ResultExpected property
        /// </summary>        
        public bool ResultExpected { get; set; }



        /// <summary>
        /// Get or set ResultActual property
        /// </summary>        
        public bool ResultActual { get; set; }



        /// <summary>
        /// Get or set TestCondition property
        /// </summary>        
        public string TestCondition { get; set; }



        /// <summary>
        /// Get or set InspectionDetails property
        /// </summary>        
        public string InspectionDetails { get; set; }

   }
}
