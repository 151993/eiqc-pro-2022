/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormMeasurementParameterActual entity model to map database FormMeasurementParameterActual table 
    /// </summary>
    public class FormMeasurementParameterActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormMeasurementParameterActual()
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
