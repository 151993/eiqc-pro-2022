using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdatePartTestReportAttachmentModel : BaseUpdateCommand<int>, IRequest<PartTestReportAttachmentModel>
	{
		/// <summary>
		/// TestReport Id
		/// </summary>
		public int TestReportId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
