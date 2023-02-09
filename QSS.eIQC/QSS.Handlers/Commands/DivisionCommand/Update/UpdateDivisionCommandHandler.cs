using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Update
{
    /// <summary>
    /// Command Handler for Update Division operation
    /// </summary>
    public class UpdateDivisionCommandHandler : IRequestHandler<UpdateDivisionModel, DivisionModel>
    {
        private readonly QSSContext _context;
        private readonly IDivisionRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateDivisionCommandHandler(QSSContext context, IDivisionRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Division entity
        /// </summary>
        /// <param name="request">Input Update Division model, <see cref="UpdateDivisionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Division model</returns>
        public async Task<DivisionModel> Handle(UpdateDivisionModel request, CancellationToken cancellationToken)
        {
            var division = _mapper.Map<Division>(request);

            await _repository.UpdateAsync(division, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DivisionModel>(division);
        }
    }
}
