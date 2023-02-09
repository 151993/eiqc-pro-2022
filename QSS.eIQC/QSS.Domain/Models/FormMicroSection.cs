/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormMicroSection entity model to map database FormMicroSection table 
    /// </summary>
    public class FormMicroSection : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormMicroSection()
        {

        }
        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        [AuditLog(DisplayName = "Instrument", ValueField = "Desc", MappingField = "InstrumentId")]
        public virtual Instrument Instrument { get; set; }
        public int? InstrumentId { get; set; }
        [AuditLog]
        public string UOM { get; set; }
    
        public double? NormalValue { get; set; }
    
        public double? UpperLimit { get; set; }
    
        public double? LowerLimit { get; set; }
    
        public int? Accuracy { get; set; }
    
        public string SampleSize { get; set; }

    }
}
