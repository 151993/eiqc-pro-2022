

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand
{
    public class SMSCommentAttachmentModel : BaseStausModel<int>
    {
        public int SupplierMeasurementSubmissionId { get; set; }

        public int AttachmentId { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public virtual AttachmentModel Attachment { get; set; }
    }
}
