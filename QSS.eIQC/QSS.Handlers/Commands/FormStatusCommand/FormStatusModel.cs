/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.FormCommand;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand
{
    /// <summary>
    /// Representation model for FormStatus entity
    /// </summary>
    public class FormStatusModel : BaseStausModel<int>
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
        /// Get or set StatusID property
        /// </summary>        
        public string StatusID { get; set; }



        /// <summary>
        /// Get or set UserName property
        /// </summary>        
        public string UserName { get; set; }



        /// <summary>
        /// Get or set LastTime property
        /// </summary>        
        public DateTimeOffset LastTime { get; set; }

    }
}
