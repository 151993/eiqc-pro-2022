/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Update
{
    /// <summary>
    /// Representation model for Update WorkCellUser operation
    /// </summary>
    public class UpdateWorkCellUserModel : BaseUpdateCommand<int>, IRequest<WorkCellUserModel>
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

        public List<int> RemovedJabilUserIds { get; set; }

        public List<int> AddedDccUserIds { get; set; }

        public List<int> RemovedDccUserIds { get; set; }

    }
}
