/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// GRSSAPResult entity model to map database GRSSAPResult table 
    /// </summary>
    public class GRSSAPResult : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string GRSNO { get; set; }
        [AuditLog]
        public string ISOK { get; set; }
        [AuditLog]
        public string Error { get; set; }
        [AuditLog]
        public string NTID { get; set; }
        [AuditLog]
        public string PayLoad { get; set; }
    }
}
