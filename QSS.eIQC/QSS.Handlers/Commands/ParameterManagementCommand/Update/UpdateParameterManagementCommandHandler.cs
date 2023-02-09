/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Update
{
    /// <summary>
    /// Command Handler for Update ParameterManagement operation
    /// </summary>
    public class UpdateParameterManagementCommandHandler : IRequestHandler<UpdateParameterManagementModel, ParameterManagementModel>
    {
        private readonly QSSContext _context;
        private readonly IParameterManagementRepository _paramRepository;
        private readonly IParameterManagementCommodityRepository _commodityRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// /// <param name="mapper">Injected instance of parameterManagementCommodityRepository on runtime, <see cref="IParameterManagementCommodityRepository"/></param>
        /// /// <param name="mapper">Injected instance of parameterManagementRepository on runtime, <see cref="IParameterManagementRepository"/></param>
        public UpdateParameterManagementCommandHandler(QSSContext context, IParameterManagementRepository parameterManagementRepository, IParameterManagementCommodityRepository parameterManagementCommodityRepository, IMapper mapper)
        {
            _context = context;
            _paramRepository = parameterManagementRepository;
            _commodityRepository = parameterManagementCommodityRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update ParameterManagement entity
        /// </summary>
        /// <param name="request">Input Update ParameterManagement model, <see cref="UpdateParameterManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated ParameterManagement model</returns>
        public async Task<ParameterManagementModel> Handle(UpdateParameterManagementModel request, CancellationToken cancellationToken)
        {
            var parameterManagement = _mapper.Map<ParameterManagement>(request);

            _commodityRepository.AddParameterCommodityNames(parameterManagement, request.AddedCommodityNameIds);

            _commodityRepository.RemoveParameterCommodityNames(parameterManagement.Id, request.RemovedCommodityNameIds);

            await _paramRepository.UpdateAsync(parameterManagement, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<ParameterManagementModel>(parameterManagement);
        }
    }
}
