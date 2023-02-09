/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Update
{
    /// <summary>
    /// Representation model for Update DCCConfiguration operation
    /// </summary>
    public class UpdateDCCConfigurationModel : BaseUpdateCommand<int>, IRequest<DCCConfigurationModel>
    {
        /// <summary>
        /// Get or set SiteNo property
        /// </summary>        
        public string SiteNo { get; set; }

        /// <summary>
        /// Get or set DeptCode property
        /// </summary>        
        public string DeptCode { get; set; }

        /// <summary>
        /// Get or set DocLevel property
        /// </summary>        
        public string DocLevel { get; set; }

        /// <summary>
        /// Get or set SiteId property
        /// </summary>        
        public int SiteId { get; set; }

    }
}
