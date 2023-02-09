/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormFunPara entity model to map database FormFunPara table 
    /// </summary>
    public class FormFunPara : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormFunPara()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public int? InstrumentId { get; set; }
        [AuditLog]
        public string UOM { get; set; }
       
        public double? NormalValue { get; set; }
       
        public double? UpperLimit { get; set; }
       
        public double? LowerLimit { get; set; }
       
        public int? Accuracy { get; set; }
        [AuditLog]
        public string SampleSize { get; set; }
    }
}
