/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Rosetta entity model to map database Rosetta table 
    /// </summary>
    public class Rosetta : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string EN_US { get; set; }
        [AuditLog]
        public string ZH_CN { get; set; }
   }
}
