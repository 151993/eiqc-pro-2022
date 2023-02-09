using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add
{
	/// <summary>
	/// Representation model for Add PartInspectionDrawing operation
	/// </summary>
	public class AddPartInspectionDrawingAttachmentModel : BaseCommand, IRequest<PartInspectionDrawingAttachmentModel>
	{
		public int SAPPartInspectionPlanId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
