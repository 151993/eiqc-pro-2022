

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Attachment entity model to map database Attachment table 
    /// </summary>
    public class Attachment : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Attachment()
        {
            this.AdminCertificationAttachments = new HashSet<AdminCertificationAttachment>();
            this.PartInspectionDrawingAttachments = new HashSet<PartInspectionDrawingAttachment>();
            this.PartInspectionSpecAttachments = new HashSet<PartInspectionSpecAttachment>();
            this.PartInspectionCertificationAttachments = new HashSet<PartInspectionCertificationAttachment>();
            this.PartTestReportAttachments = new HashSet<PartTestReportAttachment>();
            this.SupplierTestReportAttachments = new HashSet<SupplierTestReportAttachment>();
            this.SMSCommentAttachments = new HashSet<SMSCommentAttachment>();
        }


        public string Name { get; set; }

        public string SavePath { get; set; }

        /// <summary>
        /// Get or set TempSavePath property
        /// </summary>
        public string TempSavePath { get; set; }

        /// <summary>
        /// Get or set Template property
        /// </summary>
        public string Template { get; set; }

        public virtual ICollection<AdminCertificationAttachment> AdminCertificationAttachments { get; set; }

        public virtual ICollection<PartInspectionDrawingAttachment> PartInspectionDrawingAttachments { get; set; }

        public virtual ICollection<PartInspectionSpecAttachment> PartInspectionSpecAttachments { get; set; }

        public virtual ICollection<PartInspectionCertificationAttachment> PartInspectionCertificationAttachments { get; set; }

        public virtual ICollection<PartTestReportAttachment> PartTestReportAttachments { get; set; }

        public virtual ICollection<SMSCommentAttachment> SMSCommentAttachments { get; set; }

        public virtual ICollection<SupplierTestReportAttachment> SupplierTestReportAttachments { get; set; }

    }
}
