/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PCCode entity model to map database PCCode table 
    /// </summary>
    public class PCCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PCCode()
        {
            InspectionToolsTypePcCodes = new HashSet<InspectionToolsTypePcCode>();
            ParameterTypePcCodes = new HashSet<ParameterTypePcCode>();
        }
        [AuditLog]
        [Unique]
        public string Code { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<InspectionToolsTypePcCode> InspectionToolsTypePcCodes { get; set; }

        public virtual ICollection<ParameterTypePcCode> ParameterTypePcCodes { get; set; }
    }
}
