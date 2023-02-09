using QSS.eIQC.Handlers.Commands.AdminCertificationCommand;
using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using System;
using System.Collections;
using System.Collections.Generic;


namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand
{
    public class AdminCertificationAttachmentModel : BaseStausModel<int>
    {
        public int AdminCertificateId { get; set; }

        public int AttachmentId { get; set; }

        public virtual AdminCertificationModel AdminCertification { get; set; }

        public virtual AttachmentModel Attachment { get; set; }
    }
}
