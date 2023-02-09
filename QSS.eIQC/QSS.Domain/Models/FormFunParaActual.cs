/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormFunParaActual entity model to map database FormFunParaActual table 
    /// </summary>
    public class FormFunParaActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormFunParaActual()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public int No { get; set; }
        public double? ValueActual { get; set; }
    }
}
