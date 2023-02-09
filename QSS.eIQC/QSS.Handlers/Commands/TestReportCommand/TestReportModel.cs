/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand
{
    /// <summary>
    /// Representation model for TestReport entity
    /// </summary>
    public class TestReportModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        public virtual IEnumerable<CommodityModel> Commodities { get; set; }

        public virtual IEnumerable<Attachment> Attachments { get; set; }

        public bool IsChecked { get; set; }

        public int CommodityId { get; set; }

    }
}
