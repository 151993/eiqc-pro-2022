/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormResultOrientedParameter operation
    /// </summary>
    public class UpdateFormResultOrientedParameterCommandHandler : IRequestHandler<UpdateFormResultOrientedParameterModel, FormResultOrientedParameterModel>
    {
        private readonly QSSContext _context;
        private readonly IFormResultOrientedParameterRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormResultOrientedParameterCommandHandler(QSSContext context, IFormResultOrientedParameterRepository formResultOrientedParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = formResultOrientedParameterRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormResultOrientedParameter entity
        /// </summary>
        /// <param name="request">Input Update FormResultOrientedParameter model, <see cref="UpdateFormResultOrientedParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormResultOrientedParameter model</returns>
        public async Task<FormResultOrientedParameterModel> Handle(UpdateFormResultOrientedParameterModel request, CancellationToken cancellationToken)
        {
            var formResultOrientedParameter = _mapper.Map<FormResultOrientedParameter>(request);          

            await _repository.UpdateAsync(formResultOrientedParameter, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormResultOrientedParameterModel>(formResultOrientedParameter);
        }
    }
}
