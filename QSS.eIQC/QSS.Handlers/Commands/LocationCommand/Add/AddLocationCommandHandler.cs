using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.LocationCommand.Add
{
    /// <summary>
    /// Command Handler for Add Location operation
    /// </summary>
    public class AddLocationCommandHandler : IRequestHandler<AddLocationModel, LocationModel>
    {
        private readonly QSSContext _context;
        private readonly ILocationRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddLocationCommandHandler(QSSContext context, ILocationRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Location entity
        /// </summary>
        /// <param name="request">Add Location model, <see cref="AddLocationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Location model</returns>
        public async Task<LocationModel> Handle(AddLocationModel request, CancellationToken cancellationToken)
        {
            var location = _mapper.Map<Location>(request);

            await _repository.AddAsync(location, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<LocationModel>(location);
        }
    }
}
