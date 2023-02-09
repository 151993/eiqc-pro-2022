/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete InspectionToolsType operation
    /// </summary>
    public class DeleteInspectionToolsTypeCommandHandler : IRequestHandler<DeleteInspectionToolsTypeModel, DeleteInspectionToolsTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IInspectionToolsTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteInspectionToolsTypeCommandHandler(QSSContext context, IInspectionToolsTypeRepository inspectionToolsTypeRepository)
        {
            _context = context;
            _repository = inspectionToolsTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete InspectionToolsType 
        /// </summary>
        /// <param name="request">Input Delete InspectionToolsType model, <see cref="DeleteInspectionToolsTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteInspectionToolsTypeResponse"/></returns>
        public async Task<DeleteInspectionToolsTypeResponse> Handle(DeleteInspectionToolsTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteInspectionToolsTypeResponse()
            {
                Result = true
            };
        }
    }
}
