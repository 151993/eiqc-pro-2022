/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormMicroSectionActual entity model to map database SupplierFormMicroSectionActual table 
    /// </summary>
    public class SupplierFormMicroSectionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormMicroSectionActual()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        public int No { get; set; }
        public double ValueActual { get; set; }
    }
}
