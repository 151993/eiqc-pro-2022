/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormFunPara entity model to map database SupplierFormFunPara table 
    /// </summary>
    public class SupplierFormFunPara : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormFunPara()
        {
       }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        [AuditLog]
        public string InstrumentID { get; set; }
        [AuditLog]
        public string ITCode { get; set; }
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
