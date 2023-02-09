/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using MediatR;
using System;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Update
{
    /// <summary>
    /// Representation model for Update InspectionTools operation
    /// </summary>
    public class UpdateInspectionToolsModel : BaseUpdateCommand<int>, IRequest<InspectionToolsModel>
    {
        public string Name { get; set; }

        public DateTimeOffset? ValidDate { get; set; }

        public int InspectionToolsTypeId { get; set; }
    }
}
