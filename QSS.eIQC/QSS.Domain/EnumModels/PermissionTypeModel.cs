﻿using QSS.eIQC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QSS.eIQC.Domain.EnumModels
{
    [Table("PermissionType")]
    public class PermissionTypeModel : BaseEnum<PermissionType, int>
    {

    }
}
