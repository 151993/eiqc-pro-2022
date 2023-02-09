using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Add
{
    /// <summary>
    /// Command Handler for Add Country operation
    /// </summary>
    public class AddCountryCommandHandler : IRequestHandler<AddCountryModel, CountryModel>
    {
        private readonly QSSContext _context;
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCountryCommandHandler(QSSContext context, ICountryRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Country entity
        /// </summary>
        /// <param name="request">Add Country model, <see cref="AddCountryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Country model</returns>
        public async Task<CountryModel> Handle(AddCountryModel request, CancellationToken cancellationToken)
        {
            var country = _mapper.Map<Country>(request);

            await _repository.AddAsync(country, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CountryModel>(country);
        }
    }
}
