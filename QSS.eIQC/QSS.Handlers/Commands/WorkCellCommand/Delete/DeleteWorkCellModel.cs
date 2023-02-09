using MediatR;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete
{
    public class DeleteWorkCellModel : IRequest<DeleteWorkCellResponse>
    {
        /// <summary>
        /// BusinessSector Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
