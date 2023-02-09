/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteCommand.Update
{
    /// <summary>
    /// Representation model for Update Role operation
    /// </summary>
    public class UpdateSiteModel : BaseUpdateCommand<int>, IRequest<SiteModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>      
        public string Name { get; set; }

        /// <summary>
        /// Get or set Code property
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>

        public string Description { get; set; }
        
        /// Get or set locationId property
        /// </summary>        
        public int LocationId { get; set; }

        /// <summary>
        /// Get or set AddedDivisionIds property
        /// </summary>
        public List<int> AddedDivisionIds { get; set; }

        /// <summary>
        /// Get or set RemovedDivioinIds property
        /// </summary>
        public List<int> RemovedDivisionIds { get; set; }
    }
}
