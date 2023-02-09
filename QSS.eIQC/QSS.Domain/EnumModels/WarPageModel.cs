
using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("WarPage")]
    public class WarPageModel : BaseEnum<WarPage, int>
    {
        public bool IsEnabled { get; set; }
    }
}
