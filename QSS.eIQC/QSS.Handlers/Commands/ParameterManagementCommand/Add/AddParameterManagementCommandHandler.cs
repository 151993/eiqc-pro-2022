/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Add
{
    /// <summary>
    /// Command Handler for Add ParameterManagement operation
    /// </summary>
    public class AddParameterManagementCommandHandler : IRequestHandler<AddParameterManagementModel, ParameterManagementModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterManagementRepository _repository;
        private readonly IMapper _mapper;

        private readonly IParameterManagementCommodityRepository _parameterCommodityRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// /// <param name="repository">Injected instance of repository on runtime, <see cref="IParameterManagementRepository"/></param>
        /// /// <param name="parameterCommodityRepository">Injected instance of IParameterManagementCommodityRepository on runtime, <see cref="IParameterManagementCommodityRepository"/></param>
        public AddParameterManagementCommandHandler(QSSContext context, IParameterManagementRepository repository, IParameterManagementCommodityRepository parameterCommodityRepository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _parameterCommodityRepository = parameterCommodityRepository;
        }

        /// <summary>
        /// Validates the input model and Add new ParameterManagement entity
        /// </summary>
        /// <param name="request">Add ParameterManagement model, <see cref="AddParameterManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added ParameterManagement model</returns>
        public async Task<ParameterManagementModel> Handle(AddParameterManagementModel request, CancellationToken cancellationToken)
        {
            var parameterManagement = _mapper.Map<ParameterManagement>(request);

            _parameterCommodityRepository.AddParameterCommodityNames(parameterManagement, request.AddedCommodityNameIds);            

            await _repository.AddAsync(parameterManagement, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterManagementModel>(parameterManagement);
        }
    }
}
