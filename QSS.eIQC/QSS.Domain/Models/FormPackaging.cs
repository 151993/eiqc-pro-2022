/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormPackaging entity model to map database FormPackaging table 
    /// </summary>
    public class FormPackaging : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormPackaging()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ResultDesc { get; set; }
        public bool? Result { get; set; }
   }
}
