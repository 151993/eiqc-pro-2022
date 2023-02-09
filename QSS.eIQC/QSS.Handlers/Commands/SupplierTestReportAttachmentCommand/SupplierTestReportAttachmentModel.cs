

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand
{
    public class SupplierTestReportAttachmentModel : BaseStausModel<int>
    {
        public int SupplierTestReportAttachmentId { get; set; }

        public int AttachmentId { get; set; }

        public virtual SupplierTestReportModel SupplierTestReport { get; set; }

        public virtual AttachmentModel Attachment { get; set; }

    }
}
