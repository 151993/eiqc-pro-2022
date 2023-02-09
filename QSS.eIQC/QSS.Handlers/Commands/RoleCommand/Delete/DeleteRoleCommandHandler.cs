using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.RoleCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Role operation
    /// </summary>
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleModel, DeleteRoleResponse>
    {
        private readonly QSSContext _context;
        private readonly IRoleRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteRoleCommandHandler(QSSContext context, IRoleRepository roleRepository)
        {
            _context = context;
            _repository = roleRepository;
        }

        /// <summary>
        /// Handle the request to Delete Role 
        /// </summary>
        /// <param name="request">Input Delete Role model, <see cref="DeleteRoleModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteRoleResponse"/></returns>
        public async Task<DeleteRoleResponse> Handle(DeleteRoleModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteRoleResponse()
            {
                Result = true
            };
        }
    }
}
