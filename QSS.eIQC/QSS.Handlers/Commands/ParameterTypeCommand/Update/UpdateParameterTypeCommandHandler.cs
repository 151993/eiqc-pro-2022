/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCommand.Update
{
    /// <summary>
    /// Command Handler for Update ParameterType operation
    /// </summary>
    public class UpdateParameterTypeCommandHandler : IRequestHandler<UpdateParameterTypeModel, ParameterTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterTypeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateParameterTypeCommandHandler(QSSContext context, IParameterTypeRepository parameterTypeRepository, IMapper mapper)
        {
            _context = context;
            _repository = parameterTypeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update ParameterType entity
        /// </summary>
        /// <param name="request">Input Update ParameterType model, <see cref="UpdateParameterTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated ParameterType model</returns>
        public async Task<ParameterTypeModel> Handle(UpdateParameterTypeModel request, CancellationToken cancellationToken)
        {
            var parameterType = _mapper.Map<ParameterType>(request);          

            await _repository.UpdateAsync(parameterType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterTypeModel>(parameterType);
        }
    }
}
