/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Command Handler for Update SAPPartInspectionPlan operation
    /// </summary>
    public class AssignReassignSAPPartInspectionPlanToUser : IRequestHandler<AssignReassignSAPPartInspectionPlanToUserModel, SAPPartInspectionPlanModel>
    {
        private readonly QSSContext _context;
        private readonly ISAPPartInspectionPlanRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AssignReassignSAPPartInspectionPlanToUser(QSSContext context, ISAPPartInspectionPlanRepository sAPPartInspectionPlanRepository, IMapper mapper)
        {
            _context = context;
            _repository = sAPPartInspectionPlanRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SAPPartInspectionPlan entity
        /// </summary>
        /// <param name="request">Input AssignReassignSAPPartInspectionPlanToUserModel model, <see cref="AssignReassignSAPPartInspectionPlanToUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SAPPartInspectionPlan model</returns>
        public async Task<SAPPartInspectionPlanModel> Handle(AssignReassignSAPPartInspectionPlanToUserModel request, CancellationToken cancellationToken)
        {
            var existingRecord = await _context.SAPPartInspectionPlan.FindAsync(request.Id);

            existingRecord.AssignToUserId = request.AssignToUserId;

            _context.SaveChanges();

            return _mapper.Map<SAPPartInspectionPlanModel>(existingRecord);
        }
    }
}
