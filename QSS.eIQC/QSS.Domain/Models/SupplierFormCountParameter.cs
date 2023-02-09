/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormCountParameter entity model to map database SupplierFormCountParameter table 
    /// </summary>
    public class SupplierFormCountParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormCountParameter()
        {
        }

      
        [AuditLog]
        public string ParameterName { get; set; }
        public int? FailedQTYExpected { get; set; }
        
        public int? FailedQTYActual { get; set; }
       
        public int? IToolsID { get; set; }
        [AuditLog]
        public string Remark { get; set; }
        [AuditLog]
        public string InspectionDetails { get; set; }

        public int SupplierFormId { get; set; }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
    }
}
