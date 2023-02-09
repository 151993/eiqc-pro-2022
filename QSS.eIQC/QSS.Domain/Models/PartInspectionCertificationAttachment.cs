

using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class PartInspectionCertificationAttachment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        public int SAPPartInspectionPlanId { get; set; }
        [AuditLog]
        public int AttachmentId { get; set; }
        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }
        public virtual Attachment Attachment { get; set; }

        public int? UploadedByUserId { get; set; }

        [AuditLog(DisplayName = "UploadedBy", ValueField = "Name", MappingField = "UploadedByUserId")]
        [ForeignKey("UploadedByUserId")]
        public virtual User UploadedBy { get; set; }
    }
}
