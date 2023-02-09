/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddSiteUserModel : BaseCommand, IRequest<SiteUserModel>
    {
        public virtual SiteModel Site { get; set; }

        public List<int> AddedSiteUserIds { get; set; }

        public List<int> RemovedSiteUserIds { get; set; }
    }
}
