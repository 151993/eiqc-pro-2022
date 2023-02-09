/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormResultOrientedParameter operation
    /// </summary>
    public class AddFormResultOrientedParameterCommandHandler : IRequestHandler<AddFormResultOrientedParameterModel, FormResultOrientedParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormResultOrientedParameterRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormResultOrientedParameterCommandHandler(QSSContext context, IFormResultOrientedParameterRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormResultOrientedParameter entity
        /// </summary>
        /// <param name="request">Add FormResultOrientedParameter model, <see cref="AddFormResultOrientedParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormResultOrientedParameter model</returns>
        public async Task<FormResultOrientedParameterModel> Handle(AddFormResultOrientedParameterModel request, CancellationToken cancellationToken)
        {
            var formResultOrientedParameter = _mapper.Map<FormResultOrientedParameter>(request);            

            await _repository.AddAsync(formResultOrientedParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormResultOrientedParameterModel>(formResultOrientedParameter);
        }
    }
}
