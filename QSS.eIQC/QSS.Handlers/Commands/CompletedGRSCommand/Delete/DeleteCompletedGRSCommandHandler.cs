/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete CompletedGRS operation
    /// </summary>
    public class DeleteCompletedGRSCommandHandler : IRequestHandler<DeleteCompletedGRSModel, DeleteCompletedGRSResponse>
    {
        private readonly QSSContext _context;
        private readonly ICompletedGRSRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCompletedGRSCommandHandler(QSSContext context, ICompletedGRSRepository completedGRSRepository)
        {
            _context = context;
            _repository = completedGRSRepository;
        }

        /// <summary>
        /// Handle the request to Delete CompletedGRS 
        /// </summary>
        /// <param name="request">Input Delete CompletedGRS model, <see cref="DeleteCompletedGRSModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCompletedGRSResponse"/></returns>
        public async Task<DeleteCompletedGRSResponse> Handle(DeleteCompletedGRSModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteCompletedGRSResponse()
            {
                Result = true
            };
        }
    }
}
