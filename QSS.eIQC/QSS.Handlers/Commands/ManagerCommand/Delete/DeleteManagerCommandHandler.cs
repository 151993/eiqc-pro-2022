using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Manager operation
    /// </summary>
    public class DeleteManagerCommandHandler : IRequestHandler<DeleteManagerModel, DeleteManagerResponse>
    {
        private readonly QSSContext _context;
        private readonly IManagerRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteManagerCommandHandler(QSSContext context, IManagerRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Manager 
        /// </summary>
        /// <param name="request">Input Delete Manager model, <see cref="DeleteManagerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteManagerResponse"/></returns>
        public async Task<DeleteManagerResponse> Handle(DeleteManagerModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteManagerResponse()
            {
                Result = count > 0
            };
        }
    }
}
