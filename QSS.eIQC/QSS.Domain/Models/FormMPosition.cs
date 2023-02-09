/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormMPosition entity model to map database FormMPosition table 
    /// </summary>
    public class FormMPosition : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormMPosition()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string LineNo { get; set; }
        [AuditLog]
        public string ITCode { get; set; }
        [AuditLog]
        public string UOM { get; set; }
         
        public double? Spec { get; set; }
         
        public double UpperLimit { get; set; }
         
        public double LowerLimit { get; set; }
         
        public int? Accuracy { get; set; }
         
        public string SampleSize { get; set; }
         
        public double? UpperLimit1 { get; set; }
         
        public double? LowerLimit1 { get; set; }
         
        public string ITCode1 { get; set; }
         
        public double? UpperLimit2 { get; set; }
         
        public double? LowerLimit2 { get; set; }
         
        public string ITCode2 { get; set; }
         
        public double? UpperLimit3 { get; set; }
         
        public double? LowerLimit3 { get; set; }
         
        public string ITCode3 { get; set; }
        public int? PositionType { get; set; }
    }
}
