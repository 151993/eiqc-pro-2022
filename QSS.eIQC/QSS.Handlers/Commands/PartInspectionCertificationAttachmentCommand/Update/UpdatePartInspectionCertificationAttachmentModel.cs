using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdatePartInspectionCertificationAttachmentModel : BaseUpdateCommand<int>, IRequest<PartInspectionCertificationAttachmentModel>
	{
		/// <summary>
		/// SAPPartInspectionPlan Id
		/// </summary>
		public int SAPPartInspectionPlanId { get; set; }
		/// <summary>
		/// Attachment id
		/// </summary>
		public int AttachmentId { get; set; }
	}
}
