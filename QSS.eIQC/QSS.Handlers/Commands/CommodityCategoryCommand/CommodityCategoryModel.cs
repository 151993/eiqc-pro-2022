/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand
{
    /// <summary>
    /// Representation model for CommodityCategory entity
    /// </summary>
    public class CommodityCategoryModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }



        /// <summary>
        /// Get or set CommodityCategoryTypeId property
        /// </summary>        
        public int? CommodityCategoryTypeId { get; set; }

        public int? CommodityCategoryOptionId { get; set; }

        public virtual CommodityCategoryTypeModel CommodityCategoryType  { get; set; }

    }
}
