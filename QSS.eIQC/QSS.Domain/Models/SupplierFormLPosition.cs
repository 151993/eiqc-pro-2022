/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormLPosition entity model to map database SupplierFormLPosition table 
    /// </summary>
    public class SupplierFormLPosition : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormLPosition()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string LineNo { get; set; }
        [AuditLog]
        public string ITCode { get; set; }
        [AuditLog]
        public string UOM { get; set; }
        public double? Spec { get; set; }
        public double? UpperLimit { get; set; }
        public double? LowerLimit { get; set; }
        public int? Accuracy { get; set; }
        [AuditLog]
        public string SampleSize { get; set; }
        public double? UpperLimit1 { get; set; }
        public double? LowerLimit1 { get; set; }
        [AuditLog]
        public string ITCode1 { get; set; }
        public double? UpperLimit2 { get; set; }
        public double? LowerLimit2 { get; set; }
        [AuditLog]
        public string ITCode2 { get; set; }
        public double? UpperLimit3 { get; set; }
        public double? LowerLimit3 { get; set; }
        [AuditLog]
        public string ITCode3 { get; set; }
        public int? PositionType { get; set; }
    }
}
