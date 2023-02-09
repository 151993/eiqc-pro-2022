/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.UserCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand
{
    /// <summary>
    /// Representation model for SiteSme entity
    /// </summary>
    public class SiteUserModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set SiteId property
        /// </summary>        
        public int SiteId { get; set; }
        /// <summary>
        /// Get or set UserId property
        /// </summary>        
        public int UserId { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set Email property
        /// </summary>        
        public string Email { get; set; }
        /// <summary>
        /// Get or set Supervisor property
        /// </summary>        
        public string Supervisor { get; set; }
        /// <summary>
        /// Get or set SupervisorEmail property
        /// </summary>        
        public string SupervisorEmail { get; set; }

        /// <summary>
        /// Get or set Department property
        /// </summary>        
        public string Department { get; set; }

        /// <summary>
        /// Get or set SiteName property
        /// </summary>        
        public string SiteName { get; set; }

        public virtual SiteModel Site { get; set; }

        public virtual UserModel User { get; set; }

    }
}
