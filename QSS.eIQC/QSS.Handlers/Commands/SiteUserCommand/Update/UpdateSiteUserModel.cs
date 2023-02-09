/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Update
{
    /// <summary>
    /// Representation model for Update SiteSme operation
    /// </summary>
    public class UpdateSiteUserModel : BaseUpdateCommand<int>, IRequest<SiteUserModel>
    {
        public SiteModel Site { get; set; }

        public List<int> AddedSiteUserIds { get; set; }

        public List<int> RemovedSiteUserIds { get; set; }
    }
}
