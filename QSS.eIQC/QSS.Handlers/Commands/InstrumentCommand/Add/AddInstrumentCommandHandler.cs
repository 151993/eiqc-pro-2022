/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InstrumentCommand.Add
{
    /// <summary>
    /// Command Handler for Add Instrument operation
    /// </summary>
    public class AddInstrumentCommandHandler : IRequestHandler<AddInstrumentModel, InstrumentModel>
    {
        private readonly QSSContext _context;
        private readonly IInstrumentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddInstrumentCommandHandler(QSSContext context, IInstrumentRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new Instrument entity
        /// </summary>
        /// <param name="request">Add Instrument model, <see cref="AddInstrumentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Instrument model</returns>
        public async Task<InstrumentModel> Handle(AddInstrumentModel request, CancellationToken cancellationToken)
        {
            var instrument = _mapper.Map<Instrument>(request);            

            await _repository.AddAsync(instrument, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InstrumentModel>(instrument);
        }
    }
}
