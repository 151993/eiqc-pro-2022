/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormResultOrientedParameter entity model to map database FormResultOrientedParameter table 
    /// </summary>
    public class FormResultOrientedParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormResultOrientedParameter()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public bool ResultExpected { get; set; }
        public bool? ResultActual { get; set; }
        [AuditLog]
        public string TestCondition { get; set; }
        [AuditLog]
        public string InspectionDetails { get; set; }
    }
}
