using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class AdminCertificationAttachment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        public int AdminCertificateId { get; set; }
        [AuditLog]
        public int AttachmentId { get; set; }
        public virtual AdminCertification AdminCertification { get; set; }
        public virtual Attachment Attachment { get; set; }
    }
}
