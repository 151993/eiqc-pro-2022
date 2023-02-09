using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.RegionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Region operation
    /// </summary>
    public class DeleteRegionCommandHandler : IRequestHandler<DeleteRegionModel, DeleteRegionResponse>
    {
        private readonly QSSContext _context;
        private readonly IRegionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteRegionCommandHandler(QSSContext context, IRegionRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Region 
        /// </summary>
        /// <param name="request">Input Delete Region model, <see cref="DeleteRegionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteRegionResponse"/></returns>
        public async Task<DeleteRegionResponse> Handle(DeleteRegionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteRegionResponse()
            {
                Result = count > 0
            };
        }
    }
}
