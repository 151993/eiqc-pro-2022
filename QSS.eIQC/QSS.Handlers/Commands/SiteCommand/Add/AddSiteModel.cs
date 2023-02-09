/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteCommand.Add
{
    /// <summary>
    /// Representation model for Add Site operation
    /// </summary>
    public class AddSiteModel : BaseCommand, IRequest<SiteModel>
    {
        public string Name { get; set; }

        public string Code { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>

        public string Description { get; set; }
        /// <summary>
        /// Get or set locationId property
        /// </summary>        
        public int LocationId { get; set; }
        /// <summary>
        /// Get or set DivisionId's property
        /// </summary>        
        public List<int> AddedDivisionIds { get; set; }

    }
}
