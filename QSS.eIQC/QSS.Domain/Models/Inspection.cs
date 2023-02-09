/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Inspection entity model to map database Inspection table 
    /// </summary>
    public class Inspection : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Inspection()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string Inspector { get; set; }
        [AuditLog]
        public string InspectionResult { get; set; }
        [AuditLog]
        public string ReportFullName { get; set; }
    }
}
