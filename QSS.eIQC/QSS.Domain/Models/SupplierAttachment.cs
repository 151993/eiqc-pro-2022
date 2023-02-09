/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierAttachment entity model to map database SupplierAttachment table 
    /// </summary>
    public class SupplierAttachment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierAttachment()
        {
        }

        [AuditLog]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ATType { get; set; }
        [AuditLog]
        public string Path { get; set; }
    }
}
