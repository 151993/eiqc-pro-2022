/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.PCCodeCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand
{
    /// <summary>
    /// Representation model for InspectionToolsType entity
    /// </summary>
    public class InspectionToolsTypeModel : BaseStausModel<int>
    {
        public string Type { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<PCCodeModel> PCCodes { get; set; }
    }
}
