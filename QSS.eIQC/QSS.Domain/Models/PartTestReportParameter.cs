/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartTestReportParameter entity model to map database PartTestReportParameter table 
    /// </summary>
    public class PartTestReportParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartTestReportParameter()
        {
            this.PartTestReportAttachments = new HashSet<PartTestReportAttachment>();
            this.SupplierTestReports = new HashSet<SupplierTestReport>();
        }

        public int SAPPartInspectionPlanId { get; set; }

        public int TestReportId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual TestReport TestReport { get; set; }

        public virtual ICollection<PartTestReportAttachment> PartTestReportAttachments { get; set; }

        public virtual ICollection<SupplierTestReport> SupplierTestReports { get; set; }


    }
}
