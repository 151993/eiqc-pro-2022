/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CompletedGRS entity model to map database CompletedGRS table 
    /// </summary>
    public class CompletedGRS : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        [Unique]
        public string PartNo { get; set; }
        [AuditLog]
        public string UDCode { get; set; }
        [AuditLog]
        public string GRSNo { get; set; }
    }
}
