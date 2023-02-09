/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.UserCommand;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand
{
    /// <summary>
    /// Representation model for WorkCellUser entity
    /// </summary>
    public class WorkCellUserModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set IsDccApproval property
        /// </summary>        
        public bool? IsDccApproval { get; set; }

        /// <summary>
        /// Get or set WorkCell property
        /// </summary>        
        public WorkCellModel WorkCell { get; set; }

        /// <summary>
        /// Get or set WorkCellId property
        /// </summary>        
        public int WorkCellId { get; set; }

        /// <summary>
        /// Get or set Site property
        /// </summary>        
        public SiteModel Site { get; set; }

        /// <summary>
        /// Get or set SiteId property
        /// </summary>        
        public int SiteId { get; set; }

        public virtual IEnumerable<JabilUserModel> JabilUsers { get; set; }

        public virtual IEnumerable<JabilUserModel> DccUsers { get; set; }

    }
}
