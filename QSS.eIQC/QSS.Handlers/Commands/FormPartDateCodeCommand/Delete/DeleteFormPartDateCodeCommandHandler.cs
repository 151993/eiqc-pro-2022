/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormPartDateCodeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormPartDateCode operation
    /// </summary>
    public class DeleteFormPartDateCodeCommandHandler : IRequestHandler<DeleteFormPartDateCodeModel, DeleteFormPartDateCodeResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormPartDateCodeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormPartDateCodeCommandHandler(QSSContext context, IFormPartDateCodeRepository formPartDateCodeRepository)
        {
            _context = context;
            _repository = formPartDateCodeRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormPartDateCode 
        /// </summary>
        /// <param name="request">Input Delete FormPartDateCode model, <see cref="DeleteFormPartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormPartDateCodeResponse"/></returns>
        public async Task<DeleteFormPartDateCodeResponse> Handle(DeleteFormPartDateCodeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormPartDateCodeResponse()
            {
                Result = true
            };
        }
    }
}
