/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand
{
    /// <summary>
    /// Representation model for InspectionTools entity
    /// </summary>
    public class InspectionToolsModel : BaseStausModel<int>
    {
        public string Name { get; set; }

        public DateTimeOffset? ValidDate { get; set; }

        public int InspectionToolsTypeId { get; set; }

        public InspectionToolsTypeModel InspectionToolsType { get; set; }
    }
}
