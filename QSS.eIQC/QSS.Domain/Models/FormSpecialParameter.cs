/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormSpecialParameter entity model to map database FormSpecialParameter table 
    /// </summary>
    public class FormSpecialParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormSpecialParameter()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        [AuditLog]
        public string ResultDesc { get; set; }
        public bool? Result { get; set; }
    }
}
