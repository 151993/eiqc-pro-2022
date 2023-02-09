
using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("RoleEnum")]
    public class RoleEnumModel : BaseEnum<RoleEnum, int>
    {
        public bool IsEnabled { get; set; }
    }
}
