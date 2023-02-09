using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class WorkCell : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public WorkCell()
        {
            SAPPartInspectionPlans = new HashSet<SAPPartInspectionPlan>();
            WorkCellSites = new HashSet<WorkCellSite>();
            SupplierMeasurementSubmissions = new HashSet<SupplierMeasurementSubmission>();
            WorkCellUsers = new HashSet<WorkCellUser>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlans { get; set; }

        public virtual ICollection<WorkCellSite> WorkCellSites { get; set; }

        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissions { get; set; }

        public virtual ICollection<WorkCellUser> WorkCellUsers { get; set; }
    }
}
