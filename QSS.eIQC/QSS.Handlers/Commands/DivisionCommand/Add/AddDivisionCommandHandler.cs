using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Add
{
    /// <summary>
    /// Command Handler for Add Division operation
    /// </summary>
    public class AddDivisionCommandHandler : IRequestHandler<AddDivisionModel, DivisionModel>
    {
        private readonly QSSContext _context;
        private readonly IDivisionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddDivisionCommandHandler(QSSContext context, IDivisionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Division entity
        /// </summary>
        /// <param name="request">Add Division model, <see cref="AddDivisionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Division model</returns>
        public async Task<DivisionModel> Handle(AddDivisionModel request, CancellationToken cancellationToken)
        {
            var division = _mapper.Map<Division>(request);

            await _repository.AddAsync(division, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DivisionModel>(division);
        }
    }
}
