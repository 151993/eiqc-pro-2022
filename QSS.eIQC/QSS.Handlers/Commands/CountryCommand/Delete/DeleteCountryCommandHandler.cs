using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Country operation
    /// </summary>
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryModel, DeleteCountryResponse>
    {
        private readonly QSSContext _context;
        private readonly ICountryRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCountryCommandHandler(QSSContext context, ICountryRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Country 
        /// </summary>
        /// <param name="request">Input Delete Country model, <see cref="DeleteCountryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCountryResponse"/></returns>
        public async Task<DeleteCountryResponse> Handle(DeleteCountryModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteCountryResponse()
            {
                Result = count > 0
            };
        }
    }
}
