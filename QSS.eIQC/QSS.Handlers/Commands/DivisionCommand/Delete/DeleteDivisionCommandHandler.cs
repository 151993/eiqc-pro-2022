using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Division operation
    /// </summary>
    public class DeleteDivisionCommandHandler : IRequestHandler<DeleteDivisionModel, DeleteDivisionResponse>
    {
        private readonly QSSContext _context;
        private readonly IDivisionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteDivisionCommandHandler(QSSContext context, IDivisionRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Division 
        /// </summary>
        /// <param name="request">Input Delete Division model, <see cref="DeleteDivisionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteDivisionResponse"/></returns>
        public async Task<DeleteDivisionResponse> Handle(DeleteDivisionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteDivisionResponse()
            {
                Result = count > 0
            };
        }
    }
}
