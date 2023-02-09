/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand
{
    /// <summary>
    /// Representation model for FormSpecialParameter entity
    /// </summary>
    public class FormSpecialParameterModel : BaseStausModel<int>
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
        /// Get or set ResultDesc property
        /// </summary>        
        public string ResultDesc { get; set; }



        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public bool? Result { get; set; }

    }
}
