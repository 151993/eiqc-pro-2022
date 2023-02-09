/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CommodityCategory entity model to map database CommodityCategory table 
    /// </summary>
    public class CommodityCategory : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public CommodityCategory()
        {
            Commodities = new HashSet<Commodity>();
        }
        [Unique]
        public string Name { get; set; }

        public int? CommodityCategoryTypeId { get; set; }

        public int? CommodityCategoryOptionId { get; set; }

        public virtual CommodityCategoryTypeModel CommodityCategoryType { get; set; }

        public virtual CommodityCategoryOptionModel CommodityCategoryOption { get; set; }

        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
