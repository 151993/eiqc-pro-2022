/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormPackaging entity model to map database SupplierFormPackaging table 
    /// </summary>
    public class SupplierFormPackaging : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormPackaging()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ResultDesc { get; set; }
        [AuditLog]
        public bool Result { get; set; }
    }
}
