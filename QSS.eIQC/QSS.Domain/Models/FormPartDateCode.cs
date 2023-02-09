/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormPartDateCode entity model to map database FormPartDateCode table 
    /// </summary>
    public class FormPartDateCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormPartDateCode()
        {

        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string Requirement { get; set; }
        [AuditLog]
        public string SupplierDC { get; set; }
        [AuditLog]
        public string MFGDate { get; set; }
        [AuditLog]
        public string Result { get; set; }

    }
}
