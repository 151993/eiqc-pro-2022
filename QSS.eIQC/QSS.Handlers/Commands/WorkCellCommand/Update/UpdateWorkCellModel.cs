using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Update
{
    public class UpdateWorkCellModel: BaseUpdateCommand<int>, IRequest<WorkCellModel>
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        public List<int> AddedSiteIds { get; set; }

        public List<int> RemovedSiteIds { get; set; }


    }
}
