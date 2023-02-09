
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("UserType")]
    public class UserTypeModel : BaseEnum<UserType, int>
    {
        public bool IsEnabled { get; set; }
    }
}
