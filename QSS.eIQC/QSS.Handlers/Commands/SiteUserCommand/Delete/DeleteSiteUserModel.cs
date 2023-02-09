/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using QSS.eIQC.Handlers.Commands.SiteCommand;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Delete
{
    /// <summary>
    /// Representation model for Delete SiteSme operation
    /// </summary>
    public class DeleteSiteUserModel : IRequest<DeleteSiteUserResponse>
    {
        /// <summary>
        /// SiteSme Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }

        public virtual SiteModel Site { get; set; }
    }
}
