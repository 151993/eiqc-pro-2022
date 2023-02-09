/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.DivisionCommand;
using QSS.eIQC.Handlers.Commands.LocationCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SiteCommand
{
    /// <summary>
    /// Representation model for Role entity
    /// </summary>
    public class SiteModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
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
        /// <summary>
        /// Get or set locationId property
        /// </summary>        
        public int LocationId { get; set; }

        public virtual LocationModel Location { get; set; }

        public virtual IEnumerable<DivisionModel> Divisions { get; set; }

        public virtual IEnumerable<SiteUserModel> SiteUsers { get; set; }



    }
}
