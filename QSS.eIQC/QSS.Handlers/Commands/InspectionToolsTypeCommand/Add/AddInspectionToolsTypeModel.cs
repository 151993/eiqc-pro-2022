/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddInspectionToolsTypeModel : BaseCommand, IRequest<InspectionToolsTypeModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Type { get; set; }

        public string Description { get; set; }

        public List<int> AddedPcCodeIds { get; set; }
    }
}
