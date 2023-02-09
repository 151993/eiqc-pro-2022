using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("CommodityCategoryType")]
    public class CommodityCategoryTypeModel : BaseEnum<CommodityCategoryType, int>
    {
        public bool IsEnabled { get; set; }

        public virtual ICollection<CommodityCategory> CommodityCategorys { get; set; }
    }
}
