using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Add
{
    public class AddWorkCellModel : BaseCommand, IRequest<WorkCellModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> AddedSiteIds { get; set; }
    }
}
