/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.PCCodeCommand;

namespace QSS.eIQC.Handlers.Commands.ParameterCategoryCommand
{
    /// <summary>
    /// Representation model for ParameterCategory entity
    /// </summary>
    public class ParameterCategoryModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set Sequence property
        /// </summary>        
        public int? Sequence { get; set; }



        /// <summary>
        /// Get or set MultiSampling property
        /// </summary>        
        public int? MultiSampling { get; set; }



        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Get or set PCCode property
        /// </summary>        
        public PCCodeModel PCCode { get; set; }



        /// <summary>
        /// Get or set PCCodeId property
        /// </summary>        
        public int? PCCodeId { get; set; }

   }
}
