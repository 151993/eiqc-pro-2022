

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand
{
    public class PartInspectionSpecAttachmentModel : BaseStausModel<int>
    {
        public int AttachmentId { get; set; }

        public virtual AttachmentModel Attachment { get; set; }

        public int? UploadedByUserId { get; set; }

        public virtual UserModel UploadedBy { get; set; }

        public int? PartInspectionSpecificationId { get; set; }

        public virtual PartInspectionSpecificationModel PartInspectionSpecification { get; set; }
    }
}
