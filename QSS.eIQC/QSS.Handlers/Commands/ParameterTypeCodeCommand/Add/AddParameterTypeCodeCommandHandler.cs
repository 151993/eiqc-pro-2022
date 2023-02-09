/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Add
{
    /// <summary>
    /// Command Handler for Add ParameterTypeCode operation
    /// </summary>
    public class AddParameterTypeCodeCommandHandler : IRequestHandler<AddParameterTypeCodeModel, ParameterTypeCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterTypeCodeRepository _repository;
        private readonly IMapper _mapper;
        private readonly IParameterTypePcCodeRepository _parameterTypePcCodeRepository;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddParameterTypeCodeCommandHandler(QSSContext context, IParameterTypeCodeRepository repository, IMapper mapper, IParameterTypePcCodeRepository parameterTypePcCodeRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _parameterTypePcCodeRepository = parameterTypePcCodeRepository;
        }

        /// <summary>
        /// Validates the input model and Add new ParameterTypeCode entity
        /// </summary>
        /// <param name="request">Add ParameterTypeCode model, <see cref="AddParameterTypeCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ParameterTypeCode model</returns>
        public async Task<ParameterTypeCodeModel> Handle(AddParameterTypeCodeModel request, CancellationToken cancellationToken)
        {
            ParameterTypeCode parameterTypeCode = _mapper.Map<ParameterTypeCode>(request);

            _parameterTypePcCodeRepository.AddParameterTypePcCode(parameterTypeCode, request.AddedPcCodeIds);

            await _repository.AddAsync(parameterTypeCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterTypeCodeModel>(parameterTypeCode);
        }
    }
}
