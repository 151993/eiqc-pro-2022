using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{

    [Table("CommodityCategoryOption")]
    public class CommodityCategoryOptionModel : BaseEnum<CommodityCategoryOption, int>
    {
        public bool IsEnabled { get; set; }

        public virtual ICollection<Commodity> Commodities { get; set; }

        public virtual ICollection<CommodityCategory> CommodityCategorys { get; set; }

    }
}
