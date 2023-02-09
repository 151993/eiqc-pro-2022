/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete BowTwistFormula operation
    /// </summary>
    public class DeleteBowTwistFormulaCommandHandler : IRequestHandler<DeleteBowTwistFormulaModel, DeleteBowTwistFormulaResponse>
    {
        private readonly QSSContext _context;
        private readonly IBowTwistFormulaRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteBowTwistFormulaCommandHandler(QSSContext context, IBowTwistFormulaRepository bowTwistFormulaRepository)
        {
            _context = context;
            _repository = bowTwistFormulaRepository;
        }

        /// <summary>
        /// Handle the request to Delete BowTwistFormula 
        /// </summary>
        /// <param name="request">Input Delete BowTwistFormula model, <see cref="DeleteBowTwistFormulaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteBowTwistFormulaResponse"/></returns>
        public async Task<DeleteBowTwistFormulaResponse> Handle(DeleteBowTwistFormulaModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteBowTwistFormulaResponse()
            {
                Result = true
            };
        }
    }
}
