/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Update
{
    /// <summary>
    /// Representation model for Update DefectManagement operation
    /// </summary>
    public class UpdateDefectManagementModel : BaseUpdateCommand<int>, IRequest<DefectManagementModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public int DefectSectionId { get; set; }
        /// <summary>
        /// Get or set AddedDefectTypes property
        /// </summary>
        public List<string> AddedDefectTypes { get; set; }

        /// <summary>
        /// Get or set RemovedDefectTypes property
        /// </summary>
        public List<string> RemovedDefectTypes { get; set; }
    }
}
