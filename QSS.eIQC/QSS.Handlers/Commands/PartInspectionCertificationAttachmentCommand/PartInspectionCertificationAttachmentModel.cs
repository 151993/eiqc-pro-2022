

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand
{
    public class PartInspectionCertificationAttachmentModel : BaseStausModel<int>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public int AttachmentId { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public virtual AttachmentModel Attachment { get; set; }
    }
}
