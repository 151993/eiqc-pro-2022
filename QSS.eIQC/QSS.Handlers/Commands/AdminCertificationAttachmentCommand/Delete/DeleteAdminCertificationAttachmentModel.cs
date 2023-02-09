using MediatR;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Delete
{
	public class DeleteAdminCertificationAttachmentModel : IRequest<DeleteAdminCertificationAttachmentResponse>
    {
        /// <summary>
        /// AdminCertificate Id to be deleted
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
