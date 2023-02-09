using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand.Update
{
    /// <summary>
    /// Command Handler for Update WorkCell operation
    /// </summary>
    public class UpdateWorkCellCommandHandler : IRequestHandler<UpdateWorkCellModel, WorkCellModel>
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
        public UpdateWorkCellCommandHandler(QSSContext context, IWorkCellRepository repository, IMapper mapper, IWorkCellSiteRepository workCellSiteRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _workCellSiteRepository = workCellSiteRepository;
        }

        /// <summary>
        /// Validates the input model and Update WorkCell entity
        /// </summary>
        /// <param name="request">Input Update WorkCell model, <see cref="UpdateWorkCellModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated WorkCell model</returns>
        public async Task<WorkCellModel> Handle(UpdateWorkCellModel request, CancellationToken cancellationToken)
        {
            var workCell = _mapper.Map<WorkCell>(request);

            _workCellSiteRepository.AddWorkCellSites(workCell, request.AddedSiteIds);

            _workCellSiteRepository.RemoveWorkCellSites(workCell.Id, request.RemovedSiteIds);

            await _repository.UpdateAsync(workCell, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<WorkCellModel>(workCell);
        }
    }
}
