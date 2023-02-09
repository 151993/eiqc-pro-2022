using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Update
{
	/// <summary>
	/// Model received in update events
	/// </summary>
	public class UpdatePartInspectionSpecAttachmentModel : BaseUpdateCommand<int>, IRequest<PartInspectionSpecAttachmentModel>
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
