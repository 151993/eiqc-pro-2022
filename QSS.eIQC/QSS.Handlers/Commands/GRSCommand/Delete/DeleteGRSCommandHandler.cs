/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.GRSCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete GRS operation
    /// </summary>
    public class DeleteGRSCommandHandler : IRequestHandler<DeleteGRSModel, DeleteGRSResponse>
    {
        private readonly QSSContext _context;
        private readonly IGRSRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteGRSCommandHandler(QSSContext context, IGRSRepository gRSRepository)
        {
            _context = context;
            _repository = gRSRepository;
        }

        /// <summary>
        /// Handle the request to Delete GRS 
        /// </summary>
        /// <param name="request">Input Delete GRS model, <see cref="DeleteGRSModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteGRSResponse"/></returns>
        public async Task<DeleteGRSResponse> Handle(DeleteGRSModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteGRSResponse()
            {
                Result = true
            };
        }
    }
}
