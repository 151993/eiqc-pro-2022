/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormTestReport entity model to map database FormTestReport table 
    /// </summary>
    public class FormTestReport : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormTestReport()
        {

        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public bool ResultExpected { get; set; }
        [AuditLog]
        public string TestCondition { get; set; }
        public bool? ResultActual { get; set; }

    }
}
