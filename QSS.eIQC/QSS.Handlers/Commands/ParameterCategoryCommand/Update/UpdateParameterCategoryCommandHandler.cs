/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Update
{
    /// <summary>
    /// Command Handler for Update ParameterCategory operation
    /// </summary>
    public class UpdateParameterCategoryCommandHandler : IRequestHandler<UpdateParameterCategoryModel, ParameterCategoryModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterCategoryRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateParameterCategoryCommandHandler(QSSContext context, IParameterCategoryRepository parameterCategoryRepository, IMapper mapper)
        {
            _context = context;
            _repository = parameterCategoryRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update ParameterCategory entity
        /// </summary>
        /// <param name="request">Input Update ParameterCategory model, <see cref="UpdateParameterCategoryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated ParameterCategory model</returns>
        public async Task<ParameterCategoryModel> Handle(UpdateParameterCategoryModel request, CancellationToken cancellationToken)
        {
            var parameterCategory = _mapper.Map<ParameterCategory>(request);          

            await _repository.UpdateAsync(parameterCategory, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterCategoryModel>(parameterCategory);
        }
    }
}
