

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class PartInspectionSpecification : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartInspectionSpecification()
        {
            this.PartInspectionSpecAttachments = new HashSet<PartInspectionSpecAttachment>();
        }
        [AuditLog]
        public int SAPPartInspectionPlanId { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public string SpecRevisionNumber { get; set; }

        public string SpecNumber { get; set; }

        public string SpecDescription { get; set; }

        public int? SubmittedByUserId { get; set; }

        [AuditLog(DisplayName = "SubmittedBy", ValueField = "Name", MappingField = "SubmittedByUserId")]
        [ForeignKey("SubmittedByUserId")]
        public virtual User SubmittedBy { get; set; }

        public virtual ICollection<PartInspectionSpecAttachment> PartInspectionSpecAttachments { get; set; }
    }
}
