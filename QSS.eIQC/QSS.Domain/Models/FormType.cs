/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormType entity model to map database FormType table 
    /// </summary>
    public class FormType : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormType()
        {
        }

        [AuditLog]
        [Unique]
        public string Type { get; set; }
    }
}
