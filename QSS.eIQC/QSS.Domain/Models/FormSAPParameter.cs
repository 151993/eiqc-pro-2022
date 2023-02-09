/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormSAPParameter entity model to map database FormSAPParameter table 
    /// </summary>
    public class FormSAPParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormSAPParameter()
        {
        }
        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        [AuditLog]
        public string SAPParameterExpected { get; set; }
        [AuditLog]
        public string SAPParameterActual { get; set; }
    }
}
