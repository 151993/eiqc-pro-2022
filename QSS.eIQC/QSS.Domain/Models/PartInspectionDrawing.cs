

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class PartInspectionDrawing : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartInspectionDrawing()
        {
            this.PartInspectionDrawingAttachments = new HashSet<PartInspectionDrawingAttachment>();
        }
        [AuditLog]
        public int SAPPartInspectionPlanId { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public string DrawingNumber { get; set; }

        public string DrawingRevisionNumber { get; set; }

        public string DrawingDescription { get; set; }

        public int? SubmittedByUserId { get; set; }

        [AuditLog(DisplayName = "SubmittedBy", ValueField = "Name", MappingField = "SubmittedByUserId")]
        [ForeignKey("SubmittedByUserId")]
        public virtual User SubmittedBy { get; set; }

        public virtual ICollection<PartInspectionDrawingAttachment> PartInspectionDrawingAttachments { get; set; }
    }
}
