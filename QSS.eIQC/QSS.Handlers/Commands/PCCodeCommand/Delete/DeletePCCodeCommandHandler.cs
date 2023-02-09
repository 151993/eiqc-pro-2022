/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PCCodeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete PCCode operation
    /// </summary>
    public class DeletePCCodeCommandHandler : IRequestHandler<DeletePCCodeModel, DeletePCCodeResponse>
    {
        private readonly QSSContext _context;
        private readonly IPCCodeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePCCodeCommandHandler(QSSContext context, IPCCodeRepository pCCodeRepository)
        {
            _context = context;
            _repository = pCCodeRepository;
        }

        /// <summary>
        /// Handle the request to Delete PCCode 
        /// </summary>
        /// <param name="request">Input Delete PCCode model, <see cref="DeletePCCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePCCodeResponse"/></returns>
        public async Task<DeletePCCodeResponse> Handle(DeletePCCodeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePCCodeResponse()
            {
                Result = true
            };
        }
    }
}
