/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand;

namespace QSS.eIQC.Handlers.Commands.FormCountParameterCommand
{
    /// <summary>
    /// Representation model for FormCountParameter entity
    /// </summary>
    public class FormCountParameterModel : BaseStausModel<int>
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
        /// Get or set FailedQTYExpected property
        /// </summary>        
        public int? FailedQTYExpected { get; set; }



        /// <summary>
        /// Get or set FailedQTYActual property
        /// </summary>        
        public int? FailedQTYActual { get; set; }

        /// <summary>
        /// Get or set InspectionTools property
        /// </summary>        
        public InspectionToolsModel InspectionTools { get; set; }



        /// <summary>
        /// Get or set InspectionToolsId property
        /// </summary>        
        public int? InspectionToolsId { get; set; }



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
