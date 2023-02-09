using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.RegionCommand.Add
{
    /// <summary>
    /// Command Handler for Add Region operation
    /// </summary>
    public class AddRegionCommandHandler : IRequestHandler<AddRegionModel, RegionModel>
    {
        private readonly QSSContext _context;
        private readonly IRegionRepository _repository;
        private readonly IMapper _mapper;
       
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddRegionCommandHandler(QSSContext context, IRegionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Region entity
        /// </summary>
        /// <param name="request">Add Region model, <see cref="AddRegionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Region model</returns>
        public async Task<RegionModel> Handle(AddRegionModel request, CancellationToken cancellationToken)
        {
            var region = _mapper.Map<Region>(request);

            await _repository.AddAsync(region, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<RegionModel>(region);
        }
    }
}
