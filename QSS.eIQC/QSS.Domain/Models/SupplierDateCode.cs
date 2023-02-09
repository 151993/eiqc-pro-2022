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
    public class SupplierDateCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierDateCode()
        {
            SupplierMeasurementSubmissions = new HashSet<SupplierMeasurementSubmission>();
        }

        [AuditLog]
        public DateTimeOffset? ManufactureDate { get; set; }
       
        [AuditLog]
        public int? ManufactureDCWeeks { get; set; }
        [AuditLog]
        public int? ManufactureDCYears { get; set; }
        [AuditLog]
        public DateTimeOffset? SurfaceFinishingDate { get; set; }

        public int? RemainingDays { get; set; }

        public int? AcceptRejectId { get; set; }

        [AuditLog]
        public int? ShelfLifeMonths { get; set; }

        [AuditLog]
        public string DateCodeDetails { get; set; }

        [AuditLog]
        public DateTimeOffset? ExpireDate { get; set; }

        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissions { get; set; }
    }
}
