/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Update
{
    /// <summary>
    /// Command Handler for Update ParameterTypeCode operation
    /// </summary>
    public class UpdateParameterTypeCodeCommandHandler : IRequestHandler<UpdateParameterTypeCodeModel, ParameterTypeCodeModel>
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
        public UpdateParameterTypeCodeCommandHandler(QSSContext context, IParameterTypeCodeRepository parameterTypeCodeRepository, IMapper mapper, IParameterTypePcCodeRepository parameterTypePcCodeRepository)
        {
            _context = context;
            _repository = parameterTypeCodeRepository;            
            _mapper = mapper;
            _parameterTypePcCodeRepository = parameterTypePcCodeRepository;
        }

        /// <summary>
        /// Validates the input model and Update ParameterTypeCode entity
        /// </summary>
        /// <param name="request">Input Update ParameterTypeCode model, <see cref="UpdateParameterTypeCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated ParameterTypeCode model</returns>
        public async Task<ParameterTypeCodeModel> Handle(UpdateParameterTypeCodeModel request, CancellationToken cancellationToken)
        {
            var parameterTypeCode = _mapper.Map<ParameterTypeCode>(request);

            _parameterTypePcCodeRepository.AddParameterTypePcCode(parameterTypeCode, request.AddedPcCodeIds);

            _parameterTypePcCodeRepository.RemoveParameterTypePcCode(parameterTypeCode.Id, request.RemovedPcCodeIds);

            await _repository.UpdateAsync(parameterTypeCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterTypeCodeModel>(parameterTypeCode);
        }
    }
}
