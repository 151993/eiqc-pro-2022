/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormStatus entity model to map database FormStatus table 
    /// </summary>
    public class FormStatus : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormStatus()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string StatusID { get; set; }
        [AuditLog]
        public string UserName { get; set; }
        public DateTimeOffset LastTime { get; set; }
    }
}
