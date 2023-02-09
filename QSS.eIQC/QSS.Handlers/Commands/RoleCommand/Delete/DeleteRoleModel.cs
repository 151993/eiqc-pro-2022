using MediatR;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Delete
{
    /// <summary>
    /// Representation model for Delete Role operation
    /// </summary>
    public class DeleteRoleModel : IRequest<DeleteRoleResponse>
    {
        /// <summary>
        /// Role Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
