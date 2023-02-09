/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormFunParaActual entity model to map database SupplierFormFunParaActual table 
    /// </summary>
    public class SupplierFormFunParaActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormFunParaActual()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public int No { get; set; }
        public double? ValueActual { get; set; }
    }
}
