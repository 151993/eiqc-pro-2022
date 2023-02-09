/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierFormCommand;


namespace QSS.eIQC.Handlers.Commands.SupplierFormBowTwistParameterCommand
{
    /// <summary>
    /// Representation model for SupplierFormBowTwistParameter entity
    /// </summary>
    public class SupplierFormBowTwistParameterModel : BaseStausModel<int>
    {
        

        /// <summary>
        /// Get or set WarpType property
        /// </summary>        
        public int? WarpType { get; set; }



        /// <summary>
        /// Get or set Spec property
        /// </summary>        
        public string Spec { get; set; }



        /// <summary>
        /// Get or set Length property
        /// </summary>        
        public string Length { get; set; }



        /// <summary>
        /// Get or set Width property
        /// </summary>        
        public string Width { get; set; }



        /// <summary>
        /// Get or set Unit property
        /// </summary>        
        public string Unit { get; set; }



        /// <summary>
        /// Get or set UpperLimit property
        /// </summary>        
        public string UpperLimit { get; set; }        



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }
        /// <summary>
        /// Get or set SupplierForm property
        /// </summary>        
        public SupplierFormModel SupplierForm { get; set; }


    }
}
