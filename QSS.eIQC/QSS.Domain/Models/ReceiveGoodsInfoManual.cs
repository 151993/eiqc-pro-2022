/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ReceiveGoodsInfoManual entity model to map database ReceiveGoodsInfoManual table 
    /// </summary>
    public class ReceiveGoodsInfoManual : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string Plant { get; set; }
        [AuditLog]
        public string MatlGroup { get; set; }
        [AuditLog]
        public string Material { get; set; }
        [AuditLog]
        public int Quantity { get; set; }
        public DateTimeOffset? ReceivedDateTime { get; set; }
        [AuditLog]
        public string MocDoc { get; set; }
        [AuditLog]
        public string StorLoc { get; set; }
        [AuditLog]
        public string MvmtType { get; set; }
        [AuditLog]
        public string Batch { get; set; }
        [AuditLog]
        public string Vendor { get; set; }
        [AuditLog]
        public string User { get; set; }
        [AuditLog]
        public string SpecStock { get; set; }
        [AuditLog]
        public string Reference { get; set; }
    }
}
