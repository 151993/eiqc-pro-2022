
using MediatR;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Add
{
	/// <summary>
	/// Representation model for Add Certification operation
	/// </summary>
	public class AddAdminCertificationAttachmentModel : BaseCommand, IRequest<AdminCertificationAttachmentModel>
    {
		/// <summary>
		/// Commodity Id
		/// </summary>
		public int AdminCertificateId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
