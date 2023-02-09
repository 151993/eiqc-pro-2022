/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete GRSSAPResult operation
    /// </summary>
    public class DeleteGRSSAPResultCommandHandler : IRequestHandler<DeleteGRSSAPResultModel, DeleteGRSSAPResultResponse>
    {
        private readonly QSSContext _context;
        private readonly IGRSSAPResultRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteGRSSAPResultCommandHandler(QSSContext context, IGRSSAPResultRepository gRSSAPResultRepository)
        {
            _context = context;
            _repository = gRSSAPResultRepository;
        }

        /// <summary>
        /// Handle the request to Delete GRSSAPResult 
        /// </summary>
        /// <param name="request">Input Delete GRSSAPResult model, <see cref="DeleteGRSSAPResultModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteGRSSAPResultResponse"/></returns>
        public async Task<DeleteGRSSAPResultResponse> Handle(DeleteGRSSAPResultModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteGRSSAPResultResponse()
            {
                Result = true
            };
        }
    }
}
