/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// DateCode entity model to map database DateCode table 
    /// </summary>
    public class PartDateCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartDateCode()
        {
            SAPPartInspectionPlans = new HashSet<SAPPartInspectionPlan>();
        }

        [AuditLog]
        public DateTimeOffset? ManufactureDate { get; set; }
        [AuditLog]
        public int? ShelfLifeMonths { get; set; }
        [AuditLog]
        public int? ManufactureDCWeeks { get; set; }
        [AuditLog]
        public int? ManufactureDCYears { get; set; }
        [AuditLog]
        public DateTimeOffset? SurfaceFinishingDate { get; set; }
        [AuditLog]
        public string DateCodeDetails { get; set; }

        public int? DateCodeLimit { get; set; }

        [AuditLog]
        public DateTimeOffset? ExpireDate { get; set; }

        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlans { get; set; }
    }
}
