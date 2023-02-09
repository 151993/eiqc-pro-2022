/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.SiteCommand;

namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand
{
    /// <summary>
    /// Representation model for DCCConfiguration entity
    /// </summary>
    public class DCCConfigurationModel : BaseStausModel<int>
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
        /// Get or set Site property
        /// </summary>        
        public SiteModel Site { get; set; }

        /// <summary>
        /// Get or set SiteId property
        /// </summary>        
        public int SiteId { get; set; }

   }
}
