using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Update
{
    /// <summary>
    /// Command Handler for Update Manager operation
    /// </summary>
    public class UpdateManagerCommandHandler : IRequestHandler<UpdateManagerModel, ManagerModel>
    {
        private readonly QSSContext _context;
        private readonly IManagerRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateManagerCommandHandler(QSSContext context, IManagerRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Manager entity
        /// </summary>
        /// <param name="request">Input Update Manager model, <see cref="UpdateManagerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Manager model</returns>
        public async Task<ManagerModel> Handle(UpdateManagerModel request, CancellationToken cancellationToken)
        {
            var manager = _mapper.Map<Manager>(request);

            await _repository.UpdateAsync(manager, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ManagerModel>(manager);
        }
    }
}
