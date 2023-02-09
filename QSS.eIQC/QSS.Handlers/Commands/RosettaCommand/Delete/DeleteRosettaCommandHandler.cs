/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.RosettaCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Rosetta operation
    /// </summary>
    public class DeleteRosettaCommandHandler : IRequestHandler<DeleteRosettaModel, DeleteRosettaResponse>
    {
        private readonly QSSContext _context;
        private readonly IRosettaRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteRosettaCommandHandler(QSSContext context, IRosettaRepository rosettaRepository)
        {
            _context = context;
            _repository = rosettaRepository;
        }

        /// <summary>
        /// Handle the request to Delete Rosetta 
        /// </summary>
        /// <param name="request">Input Delete Rosetta model, <see cref="DeleteRosettaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteRosettaResponse"/></returns>
        public async Task<DeleteRosettaResponse> Handle(DeleteRosettaModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteRosettaResponse()
            {
                Result = true
            };
        }
    }
}
