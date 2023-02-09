using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.LocationCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Location operation
    /// </summary>
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationModel, DeleteLocationResponse>
    {
        private readonly QSSContext _context;
        private readonly ILocationRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteLocationCommandHandler(QSSContext context, ILocationRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Location 
        /// </summary>
        /// <param name="request">Input Delete Location model, <see cref="DeleteLocationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteLocationResponse"/></returns>
        public async Task<DeleteLocationResponse> Handle(DeleteLocationModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteLocationResponse()
            {
                Result = count > 0
            };
        }
    }
}
