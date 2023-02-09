/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Command Handler for Update SAPPartInspectionPlan operation
    /// </summary>
    public class ApproveRejectSAPPartInspectionPlanCommandHandler : IRequestHandler<ApproveRejectSAPPartInspectionPlanModel, SAPPartInspectionPlanModel>
    {
        private readonly QSSContext _context;
        private readonly ISAPPartInspectionPlanRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ApproveRejectSAPPartInspectionPlanCommandHandler(QSSContext context, ISAPPartInspectionPlanRepository sAPPartInspectionPlanRepository, IMapper mapper)
        {
            _context = context;
            _repository = sAPPartInspectionPlanRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SAPPartInspectionPlan entity
        /// </summary>
        /// <param name="request">Input Update SAPPartInspectionPlan model, <see cref="UpdateSAPPartInspectionPlanModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SAPPartInspectionPlan model</returns>
        public async Task<SAPPartInspectionPlanModel> Handle(ApproveRejectSAPPartInspectionPlanModel request, CancellationToken cancellationToken)
        {
            var sapPartInspectionPlan = _mapper.Map<SAPPartInspectionPlan>(request);

            await _repository.UpdateAsync(sapPartInspectionPlan, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SAPPartInspectionPlanModel>(sapPartInspectionPlan);
        }
    }
}
