

using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class PartTestReportAttachment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public int PartTestReportParameterId { get; set; }

        [AuditLog]
        public int AttachmentId { get; set; }
        public virtual PartTestReportParameter PartTestReportParameter { get; set; }
        public virtual Attachment Attachment { get; set; }

        public int? UploadedByUserId { get; set; }

        [AuditLog(DisplayName = "UploadedBy", ValueField = "Name", MappingField = "UploadedByUserId")]
        [ForeignKey("UploadedByUserId")]
        public virtual User UploadedBy { get; set; }
    }
}
