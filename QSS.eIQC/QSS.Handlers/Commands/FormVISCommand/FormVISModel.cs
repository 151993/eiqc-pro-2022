/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand
{
    /// <summary>
    /// Representation model for FormVIS entity
    /// </summary>
    public class FormVISModel : BaseStausModel<int>
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
        /// Get or set AcceptanceQTY property
        /// </summary>        
        public int? AcceptanceQTY { get; set; }



        /// <summary>
        /// Get or set TotalFailedQTY property
        /// </summary>        
        public int? TotalFailedQTY { get; set; }

    }
}
