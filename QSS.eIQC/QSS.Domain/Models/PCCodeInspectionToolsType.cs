/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PCCodeInspectionToolsType entity model to map database PCCodeInspectionToolsType table 
    /// </summary>
    public class PCCodeInspectionToolsType : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PCCodeInspectionToolsType()
        {
       }

        [AuditLog(DisplayName = "PCCode", ValueField = "PcCode", MappingField = "PCCodeId")]
        public virtual PCCode PCCode { get; set; }
        public int PCCodeId { get; set; }
        [AuditLog(DisplayName = "InspectionToolsType", ValueField = "Name", MappingField = "InspectionToolsTypeId")]
        public virtual InspectionToolsType InspectionToolsType { get; set; }
        public int InspectionToolsTypeId { get; set; }
    }
}
