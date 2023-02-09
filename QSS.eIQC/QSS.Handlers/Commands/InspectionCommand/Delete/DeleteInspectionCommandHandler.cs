/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.InspectionCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Inspection operation
    /// </summary>
    public class DeleteInspectionCommandHandler : IRequestHandler<DeleteInspectionModel, DeleteInspectionResponse>
    {
        private readonly QSSContext _context;
        private readonly IInspectionRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteInspectionCommandHandler(QSSContext context, IInspectionRepository inspectionRepository)
        {
            _context = context;
            _repository = inspectionRepository;
        }

        /// <summary>
        /// Handle the request to Delete Inspection 
        /// </summary>
        /// <param name="request">Input Delete Inspection model, <see cref="DeleteInspectionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteInspectionResponse"/></returns>
        public async Task<DeleteInspectionResponse> Handle(DeleteInspectionModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteInspectionResponse()
            {
                Result = true
            };
        }
    }
}
