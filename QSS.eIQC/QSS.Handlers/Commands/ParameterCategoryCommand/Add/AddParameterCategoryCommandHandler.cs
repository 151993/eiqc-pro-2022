/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Add
{
    /// <summary>
    /// Command Handler for Add ParameterCategory operation
    /// </summary>
    public class AddParameterCategoryCommandHandler : IRequestHandler<AddParameterCategoryModel, ParameterCategoryModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterCategoryRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddParameterCategoryCommandHandler(QSSContext context, IParameterCategoryRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new ParameterCategory entity
        /// </summary>
        /// <param name="request">Add ParameterCategory model, <see cref="AddParameterCategoryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ParameterCategory model</returns>
        public async Task<ParameterCategoryModel> Handle(AddParameterCategoryModel request, CancellationToken cancellationToken)
        {
            var parameterCategory = _mapper.Map<ParameterCategory>(request);            

            await _repository.AddAsync(parameterCategory, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterCategoryModel>(parameterCategory);
        }
    }
}
