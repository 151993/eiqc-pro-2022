/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormBowTwistParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormBowTwistParameter operation
    /// </summary>
    public class DeleteFormBowTwistParameterCommandHandler : IRequestHandler<DeleteFormBowTwistParameterModel, DeleteFormBowTwistParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormBowTwistParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormBowTwistParameterCommandHandler(QSSContext context, IFormBowTwistParameterRepository formBowTwistParameterRepository)
        {
            _context = context;
            _repository = formBowTwistParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormBowTwistParameter 
        /// </summary>
        /// <param name="request">Input Delete FormBowTwistParameter model, <see cref="DeleteFormBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormBowTwistParameterResponse"/></returns>
        public async Task<DeleteFormBowTwistParameterResponse> Handle(DeleteFormBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormBowTwistParameterResponse()
            {
                Result = true
            };
        }
    }
}
