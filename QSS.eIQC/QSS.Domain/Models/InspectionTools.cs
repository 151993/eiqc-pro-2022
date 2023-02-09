/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// InspectionTools entity model to map database InspectionTools table 
    /// </summary>
    public class InspectionTools : PersistentObjectWithUpdateAuditLogStatus<int>
    {        
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        public DateTimeOffset? ValidDate { get; set; }

        public int InspectionToolsTypeId { get; set; } 

        [AuditLog(DisplayName = "InspectionToolsType", ValueField = "Type", MappingField = "InspectionToolsTypeId")]
        public virtual InspectionToolsType InspectionToolsType { get; set; }

        public virtual ICollection<SupplierVisualInspection> SupplierVisualInspections { get; set; }

    }
}
