/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormBowTwistActual entity model to map database SupplierFormBowTwistActual table 
    /// </summary>
    public class SupplierFormBowTwistActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormBowTwistActual()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public int WarpType { get; set; }
        [AuditLog]
        public int No { get; set; }
        public double? ValueActual { get; set; }
   }
}
