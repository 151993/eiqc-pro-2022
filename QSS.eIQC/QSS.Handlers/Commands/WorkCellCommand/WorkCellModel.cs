

using QSS.eIQC.Handlers.Commands.SiteCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand
{
    public class WorkCellModel:  BaseStausModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<SiteModel> Sites { get; set; }

  
    }
}
