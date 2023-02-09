/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete PCCodeInspectionToolsType operation
    /// </summary>
    public class DeletePCCodeInspectionToolsTypeCommandHandler : IRequestHandler<DeletePCCodeInspectionToolsTypeModel, DeletePCCodeInspectionToolsTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly IPCCodeInspectionToolsTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePCCodeInspectionToolsTypeCommandHandler(QSSContext context, IPCCodeInspectionToolsTypeRepository pCCodeInspectionToolsTypeRepository)
        {
            _context = context;
            _repository = pCCodeInspectionToolsTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete PCCodeInspectionToolsType 
        /// </summary>
        /// <param name="request">Input Delete PCCodeInspectionToolsType model, <see cref="DeletePCCodeInspectionToolsTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePCCodeInspectionToolsTypeResponse"/></returns>
        public async Task<DeletePCCodeInspectionToolsTypeResponse> Handle(DeletePCCodeInspectionToolsTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePCCodeInspectionToolsTypeResponse()
            {
                Result = true
            };
        }
    }
}
