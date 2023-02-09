using MediatR;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Add
{

	/// <summary>
	/// Representation model for Add PartInspectionDrawing operation
	/// </summary>
	public class AddSMSCommentAttachmentModel : BaseCommand, IRequest<SMSCommentAttachmentModel>
	{
		public int SupplierMeasurementSubmissionId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
