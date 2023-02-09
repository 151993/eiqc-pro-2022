/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PartCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Part operation
    /// </summary>
    public class DeletePartCommandHandler : IRequestHandler<DeletePartModel, DeletePartResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartCommandHandler(QSSContext context, IPartRepository partRepository)
        {
            _context = context;
            _repository = partRepository;
        }

        /// <summary>
        /// Handle the request to Delete Part 
        /// </summary>
        /// <param name="request">Input Delete Part model, <see cref="DeletePartModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartResponse"/></returns>
        public async Task<DeletePartResponse> Handle(DeletePartModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartResponse()
            {
                Result = true
            };
        }
    }
}
