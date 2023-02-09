/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartCAF entity model to map database PartCAF table 
    /// </summary>
    public class PartCAF : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string PartNo { get; set; }
        [AuditLog]
        public string Hyperlink { get; set; }
    }
}
