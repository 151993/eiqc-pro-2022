/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Form operation
    /// </summary>
    public class DeleteFormCommandHandler : IRequestHandler<DeleteFormModel, DeleteFormResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormCommandHandler(QSSContext context, IFormRepository formRepository)
        {
            _context = context;
            _repository = formRepository;
        }

        /// <summary>
        /// Handle the request to Delete Form 
        /// </summary>
        /// <param name="request">Input Delete Form model, <see cref="DeleteFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormResponse"/></returns>
        public async Task<DeleteFormResponse> Handle(DeleteFormModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormResponse()
            {
                Result = true
            };
        }
    }
}
