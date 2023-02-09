using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Add
{

	/// <summary>
	/// Representation model for Add PartInspectionDrawing operation
	/// </summary>
	public class AddPartInspectionCertificationAttachmentModel : BaseCommand, IRequest<PartInspectionCertificationAttachmentModel>
	{
		public int SAPPartInspectionPlanId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
