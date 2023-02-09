using MediatR;

namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Delete
{
    public class DeleteManagerModel : IRequest<DeleteManagerResponse>
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
