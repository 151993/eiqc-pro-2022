/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;


namespace QSS.eIQC.Handlers.Commands.InspectionCommand
{
    /// <summary>
    /// Representation model for Inspection entity
    /// </summary>
    public class InspectionModel : BaseStausModel<int>
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
        /// Get or set Inspector property
        /// </summary>        
        public string Inspector { get; set; }



        /// <summary>
        /// Get or set InspectionResult property
        /// </summary>        
        public string InspectionResult { get; set; }



        /// <summary>
        /// Get or set ReportFullName property
        /// </summary>        
        public string ReportFullName { get; set; }


    }
}
