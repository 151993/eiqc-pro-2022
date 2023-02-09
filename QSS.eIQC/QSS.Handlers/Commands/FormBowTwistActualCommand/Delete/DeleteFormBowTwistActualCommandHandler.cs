/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormBowTwistActual operation
    /// </summary>
    public class DeleteFormBowTwistActualCommandHandler : IRequestHandler<DeleteFormBowTwistActualModel, DeleteFormBowTwistActualResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormBowTwistActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormBowTwistActualCommandHandler(QSSContext context, IFormBowTwistActualRepository formBowTwistActualRepository)
        {
            _context = context;
            _repository = formBowTwistActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormBowTwistActual 
        /// </summary>
        /// <param name="request">Input Delete FormBowTwistActual model, <see cref="DeleteFormBowTwistActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormBowTwistActualResponse"/></returns>
        public async Task<DeleteFormBowTwistActualResponse> Handle(DeleteFormBowTwistActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormBowTwistActualResponse()
            {
                Result = true
            };
        }
    }
}
