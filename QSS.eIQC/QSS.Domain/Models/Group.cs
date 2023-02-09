/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Group entity model to map database Group table 
    /// </summary>
    public class Group : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        public string WareHouse { get; set; }
        [AuditLog]
        public string UserName { get; set; }
   }
}
