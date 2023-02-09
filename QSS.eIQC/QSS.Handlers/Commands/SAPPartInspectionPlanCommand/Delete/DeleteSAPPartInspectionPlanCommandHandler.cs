/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SAPPartInspectionPlan operation
    /// </summary>
    public class DeleteSAPPartInspectionPlanCommandHandler : IRequestHandler<DeleteSAPPartInspectionPlanModel, DeleteSAPPartInspectionPlanResponse>
    {
        private readonly QSSContext _context;
        private readonly ISAPPartInspectionPlanRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSAPPartInspectionPlanCommandHandler(QSSContext context, ISAPPartInspectionPlanRepository sAPPartInspectionPlanRepository)
        {
            _context = context;
            _repository = sAPPartInspectionPlanRepository;
        }

        /// <summary>
        /// Handle the request to Delete SAPPartInspectionPlan 
        /// </summary>
        /// <param name="request">Input Delete SAPPartInspectionPlan model, <see cref="DeleteSAPPartInspectionPlanModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSAPPartInspectionPlanResponse"/></returns>
        public async Task<DeleteSAPPartInspectionPlanResponse> Handle(DeleteSAPPartInspectionPlanModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSAPPartInspectionPlanResponse()
            {
                Result = true
            };
        }
    }
}
