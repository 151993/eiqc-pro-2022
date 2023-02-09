/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierTestReport entity model to map database SupplierTestReport table 
    /// </summary>
    public class SupplierTestReport : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierTestReport()
        {
            this.SupplierTestReportAttachments = new HashSet<SupplierTestReportAttachment>();
        }

        public int SupplierMeasurementSubmissionId { get; set; }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }

        public int PartTestReportParameterId { get; set; }

        public virtual PartTestReportParameter PartTestReportParameter { get; set; }

        public int? DefectTypeId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public int ResultId { get; set; }

        [AuditLog]
        public string InspectionDetails { get; set; }

        public virtual DefectType DefectType { get; set; }

        public virtual ICollection<SupplierTestReportAttachment> SupplierTestReportAttachments { get; set; }

    }
}
