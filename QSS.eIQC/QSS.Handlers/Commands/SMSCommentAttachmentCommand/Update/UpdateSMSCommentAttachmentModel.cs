using MediatR;

namespace QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdateSMSCommentAttachmentModel : BaseUpdateCommand<int>, IRequest<SMSCommentAttachmentModel>
	{
		/// <summary>
		/// SupplierMeasurementSubmission Id
		/// </summary>
		public int SupplierMeasurementSubmissionId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
