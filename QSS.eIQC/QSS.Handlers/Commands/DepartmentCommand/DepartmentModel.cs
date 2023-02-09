using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand
{
    public class DepartmentModel : BaseStausModel<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
