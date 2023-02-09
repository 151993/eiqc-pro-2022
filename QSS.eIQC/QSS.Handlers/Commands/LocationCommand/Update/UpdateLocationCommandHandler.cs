using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.LocationCommand.Update
{
    /// <summary>
    /// Command Handler for Update Location operation
    /// </summary>
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationModel, LocationModel>
    {
        private readonly QSSContext _context;
        private readonly ILocationRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateLocationCommandHandler(QSSContext context, ILocationRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Location entity
        /// </summary>
        /// <param name="request">Input Update Location model, <see cref="UpdateLocationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Location model</returns>
        public async Task<LocationModel> Handle(UpdateLocationModel request, CancellationToken cancellationToken)
        {
            var location = _mapper.Map<Location>(request);

            await _repository.UpdateAsync(location, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<LocationModel>(location);
        }
    }
}
