/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Add
{
    /// <summary>
    /// Representation model for Add WorkCellUser operation
    /// </summary>
    public class AddWorkCellUserModel : BaseCommand, IRequest<WorkCellUserModel>
    {
        /// <summary>
        /// Get or set IsDccApproval property
        /// </summary>        
        public bool? IsDccApproval { get; set; }

        /// <summary>
        /// Get or set WorkCellId property
        /// </summary>        
        public int WorkCellId { get; set; }

        /// <summary>
        /// Get or set SiteId property
        /// </summary>        
        public int SiteId { get; set; }

        public List<int> AddedJabilUserIds { get; set; }

        public List<int> AddedDccUserIds { get; set; }

    }
}
