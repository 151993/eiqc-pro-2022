using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.UserCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete User operation
    /// </summary>
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserModel, DeleteUserResponse>
    {
        private readonly QSSContext _context;
        private readonly IUserRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteUserCommandHandler(QSSContext context, IUserRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete User 
        /// </summary>
        /// <param name="request">Input Delete User model, <see cref="DeleteUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> Handle(DeleteUserModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteUserResponse()
            {
                Result = count > 0
            };
        }
    }
}
