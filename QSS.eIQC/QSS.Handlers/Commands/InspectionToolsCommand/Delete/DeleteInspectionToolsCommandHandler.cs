/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete InspectionTools operation
    /// </summary>
    public class DeleteInspectionToolsCommandHandler : IRequestHandler<DeleteInspectionToolsModel, DeleteInspectionToolsResponse>
    {
        private readonly QSSContext _context;
        private readonly IInspectionToolsRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteInspectionToolsCommandHandler(QSSContext context, IInspectionToolsRepository inspectionToolsRepository)
        {
            _context = context;
            _repository = inspectionToolsRepository;
        }

        /// <summary>
        /// Handle the request to Delete InspectionTools 
        /// </summary>
        /// <param name="request">Input Delete InspectionTools model, <see cref="DeleteInspectionToolsModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteInspectionToolsResponse"/></returns>
        public async Task<DeleteInspectionToolsResponse> Handle(DeleteInspectionToolsModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteInspectionToolsResponse()
            {
                Result = true
            };
        }
    }
}
