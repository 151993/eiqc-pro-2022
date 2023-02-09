/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using MediatR;
using System;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Add
{
    /// <summary>
    /// Representation model for Add InspectionTools operation
    /// </summary>
    public class AddInspectionToolsModel : BaseCommand, IRequest<InspectionToolsModel>
    {
        public string Name { get; set; }

        public DateTimeOffset? ValidDate { get; set; }

        public int InspectionToolsTypeId { get; set; }
    }
}
