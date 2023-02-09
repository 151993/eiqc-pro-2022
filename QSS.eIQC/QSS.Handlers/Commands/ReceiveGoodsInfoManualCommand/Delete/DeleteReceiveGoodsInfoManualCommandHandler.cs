/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete ReceiveGoodsInfoManual operation
    /// </summary>
    public class DeleteReceiveGoodsInfoManualCommandHandler : IRequestHandler<DeleteReceiveGoodsInfoManualModel, DeleteReceiveGoodsInfoManualResponse>
    {
        private readonly QSSContext _context;
        private readonly IReceiveGoodsInfoManualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteReceiveGoodsInfoManualCommandHandler(QSSContext context, IReceiveGoodsInfoManualRepository receiveGoodsInfoManualRepository)
        {
            _context = context;
            _repository = receiveGoodsInfoManualRepository;
        }

        /// <summary>
        /// Handle the request to Delete ReceiveGoodsInfoManual 
        /// </summary>
        /// <param name="request">Input Delete ReceiveGoodsInfoManual model, <see cref="DeleteReceiveGoodsInfoManualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteReceiveGoodsInfoManualResponse"/></returns>
        public async Task<DeleteReceiveGoodsInfoManualResponse> Handle(DeleteReceiveGoodsInfoManualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteReceiveGoodsInfoManualResponse()
            {
                Result = true
            };
        }
    }
}
