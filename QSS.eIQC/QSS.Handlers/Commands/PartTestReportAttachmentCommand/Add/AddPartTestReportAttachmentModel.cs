using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Add
{

	/// <summary>
	/// Representation model for Add PartInspectionDrawing operation
	/// </summary>
	public class AddPartTestReportAttachmentModel : BaseCommand, IRequest<PartTestReportAttachmentModel>
	{
		public int TestReportId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
