using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.RegionCommand.Update
{
    /// <summary>
    /// Command Handler for Update Region operation
    /// </summary>
    public class UpdateRegionCommandHandler : IRequestHandler<UpdateRegionModel, RegionModel>
    {
        private readonly QSSContext _context;
        private readonly IRegionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateRegionCommandHandler(QSSContext context, IRegionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Region entity
        /// </summary>
        /// <param name="request">Input Update Region model, <see cref="UpdateRegionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Region model</returns>
        public async Task<RegionModel> Handle(UpdateRegionModel request, CancellationToken cancellationToken)
        {
            var region = _mapper.Map<Region>(request);
            
            await _repository.UpdateAsync(region, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<RegionModel>(region);
        }
    }
}
