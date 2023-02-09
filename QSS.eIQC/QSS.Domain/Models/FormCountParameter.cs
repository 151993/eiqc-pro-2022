/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormCountParameter entity model to map database FormCountParameter table 
    /// </summary>
    public class FormCountParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormCountParameter()
        {

        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        
        public int? FailedQTYExpected { get; set; }
        public int? FailedQTYActual { get; set; }
        [AuditLog(DisplayName = "InspectionTools", ValueField = "IToolsName", MappingField = "InspectionToolsId")]

        public virtual InspectionTools InspectionTools { get; set; }
        public int? InspectionToolsId { get; set; }
        [AuditLog]
        public string Remark { get; set; }
        [AuditLog]
        public string InspectionDetails { get; set; }

    }
}
