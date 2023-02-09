using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete WorkCell operation
    /// </summary>
    public class DeleteWorkCellCommandHandler : IRequestHandler<DeleteWorkCellModel, DeleteWorkCellResponse>
    {
        private readonly QSSContext _context;
        private readonly IWorkCellRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteWorkCellCommandHandler(QSSContext context, IWorkCellRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete WorkCell 
        /// </summary>
        /// <param name="request">Input Delete WorkCell Model, <see cref="DeleteWorkCellModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteWorkCellResponse"/></returns>
        public async Task<DeleteWorkCellResponse> Handle(DeleteWorkCellModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteWorkCellResponse()
            {
                Result = count > 0
            };
        }
    }
}
