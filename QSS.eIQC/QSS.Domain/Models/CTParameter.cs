/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CTParameter entity model to map database CTParameter table 
    /// </summary>
    public class CTParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        [Unique]
        public string Name { get; set; }
        [AuditLog]
        public string Description { get; set; }
    }
}
