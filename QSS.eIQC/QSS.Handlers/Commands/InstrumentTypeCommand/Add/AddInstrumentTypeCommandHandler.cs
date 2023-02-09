/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add InstrumentType operation
    /// </summary>
    public class AddInstrumentTypeCommandHandler : IRequestHandler<AddInstrumentTypeModel, InstrumentTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IInstrumentTypeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddInstrumentTypeCommandHandler(QSSContext context, IInstrumentTypeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new InstrumentType entity
        /// </summary>
        /// <param name="request">Add InstrumentType model, <see cref="AddInstrumentTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added InstrumentType model</returns>
        public async Task<InstrumentTypeModel> Handle(AddInstrumentTypeModel request, CancellationToken cancellationToken)
        {
            var instrumentType = _mapper.Map<InstrumentType>(request);            

            await _repository.AddAsync(instrumentType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<InstrumentTypeModel>(instrumentType);
        }
    }
}
