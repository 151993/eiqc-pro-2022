using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("ParameterManagementType")]
    public class ParameterManagementTypeModel : BaseEnum<ParameterManagementType, int>
    {
        public bool IsEnabled { get; set; }

    }
}
