/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ParameterCategory entity model to map database ParameterCategory table 
    /// </summary>
    public class ParameterCategory : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public ParameterCategory()
        {
       }

        public int? Sequence { get; set; }
        public int? MultiSampling { get; set; }
        [AuditLog]
        public string Description { get; set; }
        [AuditLog(DisplayName = "PCCode", ValueField = "PcCode", MappingField = "PCCodeId")]

        public virtual PCCode PCCode { get; set; }
        public int? PCCodeId { get; set; }
    }
}
