/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add ParameterType operation
    /// </summary>
    public class AddParameterTypeCommandHandler : IRequestHandler<AddParameterTypeModel, ParameterTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterTypeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddParameterTypeCommandHandler(QSSContext context, IParameterTypeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new ParameterType entity
        /// </summary>
        /// <param name="request">Add ParameterType model, <see cref="AddParameterTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ParameterType model</returns>
        public async Task<ParameterTypeModel> Handle(AddParameterTypeModel request, CancellationToken cancellationToken)
        {
            var parameterType = _mapper.Map<ParameterType>(request);            

            await _repository.AddAsync(parameterType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterTypeModel>(parameterType);
        }
    }
}
