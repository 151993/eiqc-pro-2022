/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete LotInspectionQty operation
    /// </summary>
    public class DeleteLotInspectionQtyCommandHandler : IRequestHandler<DeleteLotInspectionQtyModel, DeleteLotInspectionQtyResponse>
    {
        private readonly QSSContext _context;
        private readonly ILotInspectionQtyRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteLotInspectionQtyCommandHandler(QSSContext context, ILotInspectionQtyRepository lotInspectionQtyRepository)
        {
            _context = context;
            _repository = lotInspectionQtyRepository;
        }

        /// <summary>
        /// Handle the request to Delete LotInspectionQty 
        /// </summary>
        /// <param name="request">Input Delete LotInspectionQty model, <see cref="DeleteLotInspectionQtyModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteLotInspectionQtyResponse"/></returns>
        public async Task<DeleteLotInspectionQtyResponse> Handle(DeleteLotInspectionQtyModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteLotInspectionQtyResponse()
            {
                Result = true
            };
        }
    }
}
