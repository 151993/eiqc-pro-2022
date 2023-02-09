/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// GRS entity model to map database GRS table 
    /// </summary>
    public class GRS : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public GRS()
        {
        }

        [AuditLog]
        [Unique]
        public string GRSNo { get; set; }

        [AuditLog(DisplayName = "PartNo", ValueField = "PartNo", MappingField = "PartNo")]
        public virtual Part Part { get; set; }
        public string PartNo { get; set; }
        [AuditLog]
        public string MedialCode { get; set; }
        [AuditLog]
        public string MPN { get; set; }
        [AuditLog]
        public string MaterialName { get; set; }
        [AuditLog]
        public string MFG { get; set; }
        public int? Quantity { get; set; }
        [AuditLog]
        public string LotNo { get; set; }
        public int? InspectQty { get; set; }
        public int? RejectionQty { get; set; }
        [AuditLog]
        public string InspectorName { get; set; }
        [AuditLog]
        public string InspectionResult { get; set; }
        [AuditLog]
        public string GRSNoType { get; set; }
        [AuditLog]
        public string PO { get; set; }
        [AuditLog]
        public string VendorCode { get; set; }
        [AuditLog]
        public string MatlGroup { get; set; }
        [AuditLog]
        public string VendorName1 { get; set; }
        [AuditLog]
        public string SkipIQC { get; set; }
    }
}
