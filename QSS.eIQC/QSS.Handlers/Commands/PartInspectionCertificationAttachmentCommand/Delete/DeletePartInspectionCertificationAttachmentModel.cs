using MediatR;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Delete
{

    public class DeletePartInspectionCertificationAttachmentModel : IRequest<DeletePartInspectionCertificationAttachmentResponse>
    {
        /// <summary>
        /// SAPPartInspectionPlan Id to be deleted
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
