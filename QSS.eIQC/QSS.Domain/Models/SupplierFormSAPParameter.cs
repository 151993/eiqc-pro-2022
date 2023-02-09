/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormSAPParameter entity model to map database SupplierFormSAPParameter table 
    /// </summary>
    public class SupplierFormSAPParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormSAPParameter()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string ParameterName { get; set; }
        [AuditLog]
        public string SAPParameterExpected { get; set; }
        [AuditLog]
        public string SAPParameterActual { get; set; }
    }
}
