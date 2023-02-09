/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormResultOrientedParameter entity model to map database SupplierFormResultOrientedParameter table 
    /// </summary>
    public class SupplierFormResultOrientedParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormResultOrientedParameter()
        {
        }


       
        public string ParameterName { get; set; }
        [AuditLog]
        public bool ResultExpected { get; set; }
        [AuditLog]
        public bool ResultActual { get; set; }
        [AuditLog]
        public string TestCondition { get; set; }
        [AuditLog]
        public string InspectionDetails { get; set; }

        public int SupplierFormId { get; set; }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
    }
}
