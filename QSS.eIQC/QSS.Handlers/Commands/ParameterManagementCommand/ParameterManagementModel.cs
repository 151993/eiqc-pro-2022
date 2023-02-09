/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand
{
    /// <summary>
    /// Representation model for ParameterManagement entity
    /// </summary>
    public class ParameterManagementModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Get or set TypeId property
        /// </summary>        
        public int ParameterTypeCodeId { get; set; }

        public bool IsChecked { get; set; }

        public int ParameterManagementTypeId { get; set; }

        public virtual ParameterTypeCodeModel ParameterTypeCode { get; set; }

        public virtual IEnumerable<CommodityModel> Commodities { get; set; }

    }
}
