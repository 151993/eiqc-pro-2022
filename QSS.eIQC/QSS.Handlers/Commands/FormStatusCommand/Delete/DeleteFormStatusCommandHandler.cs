/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormStatusCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormStatus operation
    /// </summary>
    public class DeleteFormStatusCommandHandler : IRequestHandler<DeleteFormStatusModel, DeleteFormStatusResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormStatusRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormStatusCommandHandler(QSSContext context, IFormStatusRepository FormStatusRepository)
        {
            _context = context;
            _repository = FormStatusRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormStatus 
        /// </summary>
        /// <param name="request">Input Delete FormStatus model, <see cref="DeleteFormStatusModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormStatusResponse"/></returns>
        public async Task<DeleteFormStatusResponse> Handle(DeleteFormStatusModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormStatusResponse()
            {
                Result = true
            };
        }
    }
}
