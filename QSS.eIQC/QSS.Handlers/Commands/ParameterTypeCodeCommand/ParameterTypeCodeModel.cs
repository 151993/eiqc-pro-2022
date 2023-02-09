
using System.Collections.Generic;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.PCCodeCommand;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand
{
    /// <summary>
    /// Representation model for ParameterTypeCode entity
    /// </summary>
    public class ParameterTypeCodeModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set ParameterManagementTypeId property
        /// </summary>        
        public int ParameterManagementTypeId { get; set; }


        public virtual IEnumerable<PCCodeModel> PCCodes { get; set; }

        public virtual ParameterManagementTypeModel ParameterManagementType { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        public string PMTDescription { get; set; }

    }
}
