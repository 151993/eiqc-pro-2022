/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete UOM operation
    /// </summary>
    public class DeleteUOMCommandHandler : IRequestHandler<DeleteUOMModel, DeleteUOMResponse>
    {
        private readonly QSSContext _context;
        private readonly IUOMRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteUOMCommandHandler(QSSContext context, IUOMRepository uOMRepository)
        {
            _context = context;
            _repository = uOMRepository;
        }

        /// <summary>
        /// Handle the request to Delete UOM 
        /// </summary>
        /// <param name="request">Input Delete UOM model, <see cref="DeleteUOMModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteUOMResponse"/></returns>
        public async Task<DeleteUOMResponse> Handle(DeleteUOMModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteUOMResponse()
            {
                Result = true
            };
        }
    }
}
