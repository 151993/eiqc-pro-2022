using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Add
{
    /// <summary>
    /// Command Handler for Add WorkCell operation
    /// </summary>
    public class AddWorkCellCommandHandler : IRequestHandler<AddWorkCellModel, WorkCellModel>
    {
        private readonly QSSContext _context;
        private readonly IWorkCellRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWorkCellSiteRepository _workCellSiteRepository;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddWorkCellCommandHandler(QSSContext context, IWorkCellRepository repository, IMapper mapper, IWorkCellSiteRepository workCellSiteRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _workCellSiteRepository = workCellSiteRepository;

        }

        /// <summary>
        /// Validates the input model and Add new WorkCell entity
        /// </summary>
        /// <param name="request">Add WorkCell model, <see cref="AddWorkCellModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added WorkCell model</returns>
        public async Task<WorkCellModel> Handle(AddWorkCellModel request, CancellationToken cancellationToken)
        {
            var workcell = _mapper.Map<WorkCell>(request);

            _workCellSiteRepository.AddWorkCellSites(workcell, request.AddedSiteIds);

            await _repository.AddAsync(workcell, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<WorkCellModel>(workcell);
        }
    }
}
