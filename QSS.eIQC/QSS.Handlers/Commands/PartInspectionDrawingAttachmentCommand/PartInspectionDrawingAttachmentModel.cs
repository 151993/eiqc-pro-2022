using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand
{

    public class PartInspectionDrawingAttachmentModel : BaseStausModel<int>
    {
        public int AttachmentId { get; set; }

        public virtual AttachmentModel Attachment { get; set; }

        public int? UploadedByUserId { get; set; }

        public virtual UserModel UploadedBy { get; set; }

        public int? PartInspectionDrawingId { get; set; }

        public virtual PartInspectionDrawingModel PartInspectionDrawing { get; set; }
    }
}
