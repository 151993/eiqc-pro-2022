/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Update
{
    /// <summary>
    /// Representation model for Update InspectionToolsType operation
    /// </summary>
    public class UpdateInspectionToolsTypeModel : BaseUpdateCommand<int>, IRequest<InspectionToolsTypeModel>
    {
        public string Type { get; set; }

        public string Description { get; set; }

        public List<int> AddedPcCodeIds { get; set; }

        public List<int> RemovedPcCodeIds { get; set; }


    }
}
