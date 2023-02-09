

using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.TestReportCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand
{
    public class PartTestReportAttachmentModel : BaseStausModel<int>
    {
        public int PartTestReportParameterId { get; set; }

        public int AttachmentId { get; set; }

        public virtual PartTestReportParameterModel PartTestReportParameter { get; set; }

        public virtual AttachmentModel Attachment { get; set; }

    }
}
