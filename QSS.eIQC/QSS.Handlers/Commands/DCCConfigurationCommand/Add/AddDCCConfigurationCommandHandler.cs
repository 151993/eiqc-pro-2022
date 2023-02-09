/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add
{
    /// <summary>
    /// Command Handler for Add DCCConfiguration operation
    /// </summary>
    public class AddDCCConfigurationCommandHandler : IRequestHandler<AddDCCConfigurationModel, DCCConfigurationModel>
    {
        private readonly QSSContext _context;
        private readonly IDCCConfigurationRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddDCCConfigurationCommandHandler(QSSContext context, IDCCConfigurationRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new DCCConfiguration entity
        /// </summary>
        /// <param name="request">Add DCCConfiguration model, <see cref="AddDCCConfigurationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added DCCConfiguration model</returns>
        public async Task<DCCConfigurationModel> Handle(AddDCCConfigurationModel request, CancellationToken cancellationToken)
        {
            var dCCConfiguration = _mapper.Map<DCCConfiguration>(request);            

            await _repository.AddAsync(dCCConfiguration, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DCCConfigurationModel>(dCCConfiguration);
        }
    }
}
