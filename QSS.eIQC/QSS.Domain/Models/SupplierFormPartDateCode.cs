/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormPartDateCode entity model to map database SupplierFormPartDateCode table 
    /// </summary>
    public class SupplierFormPartDateCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormPartDateCode()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string Requirement { get; set; }
        [AuditLog]
        public string SupplierDC { get; set; }
        [AuditLog]
        public string MFGDate { get; set; }
        [AuditLog]
        public string Result { get; set; }
  }
}
