using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Add
{
    /// <summary>
    /// Command Handler for Add Manager operation
    /// </summary>
    public class AddManagerCommandHandler : IRequestHandler<AddManagerModel, ManagerModel>
    {
        private readonly QSSContext _context;
        private readonly IManagerRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddManagerCommandHandler(QSSContext context, IManagerRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Manager entity
        /// </summary>
        /// <param name="request">Add Manager model, <see cref="AddManagerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Manager model</returns>
        public async Task<ManagerModel> Handle(AddManagerModel request, CancellationToken cancellationToken)
        {
            var manager = _mapper.Map<Manager>(request);

            await _repository.AddAsync(manager, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ManagerModel>(manager);
        }
    }
}
