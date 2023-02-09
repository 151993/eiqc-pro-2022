/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormMPositionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormMPositionActual operation
    /// </summary>
    public class DeleteFormMPositionActualCommandHandler : IRequestHandler<DeleteFormMPositionActualModel, DeleteFormMPositionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormMPositionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormMPositionActualCommandHandler(QSSContext context, IFormMPositionActualRepository formMPositionActualRepository)
        {
            _context = context;
            _repository = formMPositionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormMPositionActual 
        /// </summary>
        /// <param name="request">Input Delete FormMPositionActual model, <see cref="DeleteFormMPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormMPositionActualResponse"/></returns>
        public async Task<DeleteFormMPositionActualResponse> Handle(DeleteFormMPositionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormMPositionActualResponse()
            {
                Result = true
            };
        }
    }
}
