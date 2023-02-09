using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Update
{
  

    /// <summary>
    /// Command Handler for Update Country operation
    /// </summary>
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryModel, CountryModel>
    {
        private readonly QSSContext _context;
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateCountryCommandHandler(QSSContext context, ICountryRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Country entity
        /// </summary>
        /// <param name="request">Input Update Country model, <see cref="UpdateCountryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Country model</returns>
        public async Task<CountryModel> Handle(UpdateCountryModel request, CancellationToken cancellationToken)
        {
            var country = _mapper.Map<Country>(request);

            await _repository.UpdateAsync(country, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CountryModel>(country);
        }
    }
}
