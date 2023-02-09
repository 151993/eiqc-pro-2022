/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand
{
    /// <summary>
    /// Representation model for FormBowTwistActual entity
    /// </summary>
    public class FormBowTwistActualModel : BaseStausModel<int>
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
        /// Get or set SAPParameterExpected property
        /// </summary>        
        public string SAPParameterExpected { get; set; }



        /// <summary>
        /// Get or set SAPParameterActual property
        /// </summary>        
        public string SAPParameterActual { get; set; }

   }
}
