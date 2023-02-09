using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdatePartInspectionDrawingAttachmentModel : BaseUpdateCommand<int>, IRequest<PartInspectionDrawingAttachmentModel>
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
