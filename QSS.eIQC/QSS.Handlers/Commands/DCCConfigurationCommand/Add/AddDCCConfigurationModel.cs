/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add
{
    /// <summary>
    /// Representation model for Add DCCConfiguration operation
    /// </summary>
    public class AddDCCConfigurationModel : BaseCommand, IRequest<DCCConfigurationModel>
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
