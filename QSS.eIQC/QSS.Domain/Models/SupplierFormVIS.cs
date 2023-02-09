/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormVIS entity model to map database SupplierFormVIS table 
    /// </summary>
    public class SupplierFormVIS : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormVIS()
        {

        }

        
        [AuditLog]
        public int AcceptanceQTY { get; set; }
        [AuditLog]
        public int TotalFailedQTY { get; set; }

        public int SupplierFormId { get; set; }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }

    }
}
