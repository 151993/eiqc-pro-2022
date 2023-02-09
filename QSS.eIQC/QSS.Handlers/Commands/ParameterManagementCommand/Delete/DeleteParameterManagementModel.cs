using MediatR;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Delete
{
    /// <summary>
    /// Representation model for Delete ParameterManagement operation
    /// </summary>
    public class DeleteParameterManagementModel : IRequest<DeleteParameterManagementResponse>
    {
        /// <summary>
        /// ParameterManagement Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
