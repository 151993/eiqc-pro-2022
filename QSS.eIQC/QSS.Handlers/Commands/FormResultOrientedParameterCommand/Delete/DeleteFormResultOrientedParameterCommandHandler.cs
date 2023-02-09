/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormResultOrientedParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormResultOrientedParameter operation
    /// </summary>
    public class DeleteFormResultOrientedParameterCommandHandler : IRequestHandler<DeleteFormResultOrientedParameterModel, DeleteFormResultOrientedParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormResultOrientedParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormResultOrientedParameterCommandHandler(QSSContext context, IFormResultOrientedParameterRepository formResultOrientedParameterRepository)
        {
            _context = context;
            _repository = formResultOrientedParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormResultOrientedParameter 
        /// </summary>
        /// <param name="request">Input Delete FormResultOrientedParameter model, <see cref="DeleteFormResultOrientedParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormResultOrientedParameterResponse"/></returns>
        public async Task<DeleteFormResultOrientedParameterResponse> Handle(DeleteFormResultOrientedParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormResultOrientedParameterResponse()
            {
                Result = true
            };
        }
    }
}
