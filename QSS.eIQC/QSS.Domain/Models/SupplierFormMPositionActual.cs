/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierFormMPositionActual entity model to map database SupplierFormMPositionActual table 
    /// </summary>
    public class SupplierFormMPositionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFormMPositionActual()
        {
        }

        [AuditLog(DisplayName = "PONo", ValueField = "PONo", MappingField = "SupplierFormId")]
        public virtual SupplierForm SupplierForm { get; set; }
        public int SupplierFormId { get; set; }
        [AuditLog]
        public string LineNo { get; set; }
        public int No { get; set; }
        public double? ValueActual { get; set; }
        public double? PositionCalcul { get; set; }
        public double? PositionActual { get; set; }
        [AuditLog]
        public string Result { get; set; }
        [AuditLog]
        public string InstrumentID { get; set; }
        public double? Base1Actual { get; set; }
        public double? Base2Actual { get; set; }
        public double? Base3Actual { get; set; }
        [AuditLog]
        public string InstrumentID1 { get; set; }
        [AuditLog]
        public string InstrumentID2 { get; set; }
        [AuditLog]
        public string InstrumentID3 { get; set; }
        public int? PositionType { get; set; }
    }
}
