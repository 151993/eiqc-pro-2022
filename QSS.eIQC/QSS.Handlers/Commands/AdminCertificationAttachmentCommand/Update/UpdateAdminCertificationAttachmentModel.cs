using MediatR;


namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdateAdminCertificationAttachmentModel : BaseUpdateCommand<int>, IRequest<AdminCertificationAttachmentModel>
    {
		/// <summary>
		/// AdminCertificate Id
		/// </summary>
		public int AdminCertificateId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
