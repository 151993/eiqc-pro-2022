/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormPartSAPFailedQty operation
    /// </summary>
    public class DeleteFormPartSAPFailedQtyCommandHandler : IRequestHandler<DeleteFormPartSAPFailedQtyModel, DeleteFormPartSAPFailedQtyResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormPartSAPFailedQtyRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormPartSAPFailedQtyCommandHandler(QSSContext context, IFormPartSAPFailedQtyRepository formPartSAPFailedQtyRepository)
        {
            _context = context;
            _repository = formPartSAPFailedQtyRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormPartSAPFailedQty 
        /// </summary>
        /// <param name="request">Input Delete FormPartSAPFailedQty model, <see cref="DeleteFormPartSAPFailedQtyModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormPartSAPFailedQtyResponse"/></returns>
        public async Task<DeleteFormPartSAPFailedQtyResponse> Handle(DeleteFormPartSAPFailedQtyModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormPartSAPFailedQtyResponse()
            {
                Result = true
            };
        }
    }
}
