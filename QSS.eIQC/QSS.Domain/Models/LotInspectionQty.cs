/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// LotInspectionQty entity model to map database LotInspectionQty table 
    /// </summary>
    public class LotInspectionQty : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string LotNo { get; set; }
        [AuditLog]
        public string Material { get; set; }
        [AuditLog]
        public string MstrChar { get; set; }
        [AuditLog]
        public string InspStg { get; set; }
        [AuditLog]
        public int INspectQty { get; set; }
    }
}
