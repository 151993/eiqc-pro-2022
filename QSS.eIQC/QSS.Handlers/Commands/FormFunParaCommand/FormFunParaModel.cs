/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Handlers.Commands.FormFunParaCommand
{
    /// <summary>
    /// Representation model for FormFunPara entity
    /// </summary>
    public class FormFunParaModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Form property
        /// </summary>        
        public FormModel Form { get; set; }



        /// <summary>
        /// Get or set FormId property
        /// </summary>        
        public int FormId { get; set; }



        /// <summary>
        /// Get or set ParameterName property
        /// </summary>        
        public string ParameterName { get; set; }



        /// <summary>
        /// Get or set InstrumentId property
        /// </summary>        
        public int? InstrumentId { get; set; }



        /// <summary>
        /// Get or set UOM property
        /// </summary>        
        public string UOM { get; set; }



        /// <summary>
        /// Get or set NormalValue property
        /// </summary>        
        public double? NormalValue { get; set; }



        /// <summary>
        /// Get or set UpperLimit property
        /// </summary>        
        public double? UpperLimit { get; set; }



        /// <summary>
        /// Get or set LowerLimit property
        /// </summary>        
        public double? LowerLimit { get; set; }



        /// <summary>
        /// Get or set Accuracy property
        /// </summary>        
        public int? Accuracy { get; set; }



        /// <summary>
        /// Get or set SampleSize property
        /// </summary>        
        public string SampleSize { get; set; }

    }
}
