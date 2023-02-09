/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Buyer operation
    /// </summary>
    public class DeleteBuyerCommandHandler : IRequestHandler<DeleteBuyerModel, DeleteBuyerResponse>
    {
        private readonly QSSContext _context;
        private readonly IBuyerRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteBuyerCommandHandler(QSSContext context, IBuyerRepository buyerRepository)
        {
            _context = context;
            _repository = buyerRepository;
        }

        /// <summary>
        /// Handle the request to Delete Buyer 
        /// </summary>
        /// <param name="request">Input Delete Buyer model, <see cref="DeleteBuyerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteBuyerResponse"/></returns>
        public async Task<DeleteBuyerResponse> Handle(DeleteBuyerModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteBuyerResponse()
            {
                Result = true
            };
        }
    }
}
