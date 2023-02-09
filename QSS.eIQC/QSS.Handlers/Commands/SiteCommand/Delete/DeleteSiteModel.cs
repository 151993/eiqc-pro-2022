/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.SiteCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Site operation
    /// </summary>
    public class DeleteSiteModel : IRequest<DeleteSiteResponse>
    {
        /// <summary>
        /// Site Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
