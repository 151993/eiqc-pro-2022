using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Add
{

	/// <summary>
	/// Representation model for Add PartInspectionDrawing operation
	/// </summary>
	public class AddPartInspectionSpecAttachmentModel : BaseCommand, IRequest<PartInspectionSpecAttachmentModel>
	{
		public int SAPPartInspectionPlanId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
