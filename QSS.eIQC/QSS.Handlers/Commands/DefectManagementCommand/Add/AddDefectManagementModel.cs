/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Add
{
    /// <summary>
    /// Representation model for Add DefectManagement operation
    /// </summary>
    public class AddDefectManagementModel : BaseCommand, IRequest<DefectManagementModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public int DefectSectionId { get; set; }

        public List<string> AddedDefectTypes { get; set; }


    }
}
