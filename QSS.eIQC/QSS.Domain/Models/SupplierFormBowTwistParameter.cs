/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormBowTwistParameter entity model to map database SupplierFormBowTwistParameter table 
    /// </summary>
    public class SupplierFormBowTwistParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormBowTwistParameter()
        {
        }

        public int WarpType { get; set; }
        [AuditLog]
        public string Spec { get; set; }
        [AuditLog]
        public string Length { get; set; }
        [AuditLog]
        public string Width { get; set; }
        [AuditLog]
        public string Unit { get; set; }
        [AuditLog]
        public string UpperLimit { get; set; }

        public int SupplierFormId { get; set; }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
    }
}
