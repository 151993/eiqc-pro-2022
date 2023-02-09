/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete FormLPositionActual operation
    /// </summary>
    public class DeleteFormLPositionActualCommandHandler : IRequestHandler<DeleteFormLPositionActualModel, DeleteFormLPositionActualResponse>
    {
        private readonly QSSContext _context;
        private readonly IFormLPositionActualRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteFormLPositionActualCommandHandler(QSSContext context, IFormLPositionActualRepository formLPositionActualRepository)
        {
            _context = context;
            _repository = formLPositionActualRepository;
        }

        /// <summary>
        /// Handle the request to Delete FormLPositionActual 
        /// </summary>
        /// <param name="request">Input Delete FormLPositionActual model, <see cref="DeleteFormLPositionActualModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteFormLPositionActualResponse"/></returns>
        public async Task<DeleteFormLPositionActualResponse> Handle(DeleteFormLPositionActualModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteFormLPositionActualResponse()
            {
                Result = true
            };
        }
    }
}
