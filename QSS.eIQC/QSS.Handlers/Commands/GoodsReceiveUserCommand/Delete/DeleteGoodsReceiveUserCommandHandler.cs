/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete GoodsReceiveUser operation
    /// </summary>
    public class DeleteGoodsReceiveUserCommandHandler : IRequestHandler<DeleteGoodsReceiveUserModel, DeleteGoodsReceiveUserResponse>
    {
        private readonly QSSContext _context;
        private readonly IGoodsReceiveUserRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteGoodsReceiveUserCommandHandler(QSSContext context, IGoodsReceiveUserRepository goodsReceiveUserRepository)
        {
            _context = context;
            _repository = goodsReceiveUserRepository;
        }

        /// <summary>
        /// Handle the request to Delete GoodsReceiveUser 
        /// </summary>
        /// <param name="request">Input Delete GoodsReceiveUser model, <see cref="DeleteGoodsReceiveUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteGoodsReceiveUserResponse"/></returns>
        public async Task<DeleteGoodsReceiveUserResponse> Handle(DeleteGoodsReceiveUserModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteGoodsReceiveUserResponse()
            {
                Result = true
            };
        }
    }
}
