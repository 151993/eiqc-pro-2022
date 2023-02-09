/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormBowTwistParameter entity model to map database FormBowTwistParameter table 
    /// </summary>
    public class FormBowTwistParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormBowTwistParameter()
        {
        }
        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        public int? WarpType { get; set; }
        public string Spec { get; set; }
        [AuditLog]
        public string Length { get; set; }
        [AuditLog]
        public string Width { get; set; }
        [AuditLog]
        public string Unit { get; set; }
        [AuditLog]
        public string UpperLimit { get; set; }
   }
}
