/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete ReceiveGoodsInfo operation
    /// </summary>
    public class DeleteReceiveGoodsInfoCommandHandler : IRequestHandler<DeleteReceiveGoodsInfoModel, DeleteReceiveGoodsInfoResponse>
    {
        private readonly QSSContext _context;
        private readonly IReceiveGoodsInfoRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteReceiveGoodsInfoCommandHandler(QSSContext context, IReceiveGoodsInfoRepository receiveGoodsInfoRepository)
        {
            _context = context;
            _repository = receiveGoodsInfoRepository;
        }

        /// <summary>
        /// Handle the request to Delete ReceiveGoodsInfo 
        /// </summary>
        /// <param name="request">Input Delete ReceiveGoodsInfo model, <see cref="DeleteReceiveGoodsInfoModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteReceiveGoodsInfoResponse"/></returns>
        public async Task<DeleteReceiveGoodsInfoResponse> Handle(DeleteReceiveGoodsInfoModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteReceiveGoodsInfoResponse()
            {
                Result = true
            };
        }
    }
}
